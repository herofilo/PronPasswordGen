using System;
using System.Reflection;

namespace PronPasswordGen.Util
{
    public static class Utils
    {
        private static Random _random = new Random();

        private static string _versionString = null;

        // ----------------------------------------------------------------------------------------------------------

        public static bool Coin()
        {
            return ((_random.Next(10) % 2) == 0);
        }



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

    }
}
