using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace PronPasswordGen.Util
{
    public static class Utils
    {
        private static Random _random = new Random();

        private static string _versionString = null;

        private static string _executableDirectory = null;

        // ----------------------------------------------------------------------------------------------------------

        public static bool Coin()
        {
            return ((_random.Next(10) % 2) == 0);
        }


        // -----------------------------------------------------------------------------------------------------------------


        /// <summary>
        /// Gets a string containing the version of the executable (major + minor + build)
        /// </summary>
        /// <returns>Version string of the executable</returns>
        public static string GetExecutableVersion()
        {
            if (_versionString != null)
                return _versionString;

            Version version =
                Assembly.GetEntryAssembly()?.GetName().Version;

            string revision = (version.Revision > 0) ? $".{version.Revision}" : "";


            return (_versionString = (version == null) ? "?" : $"{version.Major}.{version.Minor}.{version.Build}{revision}");
        }


        /// <summary>
        /// Gets the executable home folder
        /// </summary>
        /// <returns>Path to the executable home folder</returns>
        public static string GetExecutableDirectory()
        {
            return _executableDirectory ?? (_executableDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location));
        }


        public static string GetExceptionExtendedMessage(Exception pException)
        {
            string text = pException.Message;

            string innerExceptionText = null;

            while (pException.InnerException != null)
            {
                innerExceptionText = pException.InnerException.Message;
                pException = pException.InnerException;
            }

            if (innerExceptionText == null)
                return text;

            return $"{text} [{innerExceptionText}]";
        }

        // -------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Extension method for Tooltips 
        /// </summary>
        /// <param name="pToolTip">tooltip</param>
        public static void SetDefaults(this ToolTip pToolTip)
        {
            // Set up the delays for the ToolTip.
            pToolTip.AutoPopDelay = 5000;
            pToolTip.InitialDelay = 1000;
            pToolTip.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            pToolTip.ShowAlways = true;
        }

    }
}
