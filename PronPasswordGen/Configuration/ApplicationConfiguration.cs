using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using PronPasswordGen.Domain.Generator;
using PronPasswordGen.Util;

namespace PronPasswordGen.Configuration
{
    [Serializable]
    public class ApplicationConfiguration : ConfigurationFileBase
    {
        
        public int PasswordLength { get; set; }

        public int PasswordCount { get; set; }
        
        public PasswordGeneratorOptionsEx Options { get; set; }

        [XmlArrayItem("ChunkTypeWeight")]
        public List<PasswordChunkTypeWeight> ChunkTypeWeights { get; set; }



        public static string ConfigurationFilePath => Path.Combine(Utils.GetExecutableDirectory(), "PronPasswordGen.cfg");


        // ----------------------------------------------------------------------------

        public ApplicationConfiguration()
        {

        }


        // ----------------------------------------------------------------------------

        /// <summary>
        /// Loads configuration from file
        /// </summary>
        /// <param name="pErrorText">Text of error, if any</param>
        /// <returns>Application configuration loaded (or null, if failed)</returns>
        public static ApplicationConfiguration Load(out string pErrorText)
        {
            pErrorText = null;

            string configurationFilename = ConfigurationFilePath;
            
            if (!File.Exists(configurationFilename))
            {
                return null;
            }

            ApplicationConfiguration configurationInfo = new ApplicationConfiguration();

            try
            {
                XmlSerializer serializer = new XmlSerializer(configurationInfo.GetType());
                using (StreamReader reader = new StreamReader(configurationFilename))
                {
                    configurationInfo = (ApplicationConfiguration)serializer.Deserialize(reader);
                    reader.Close();
                }
            }
            catch (Exception exception)
            {
                pErrorText = Utils.GetExceptionExtendedMessage(exception);
                configurationInfo = null;
            }
            return configurationInfo;
        }

    }
}
