using System;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Win11ClockToggler
{
    //Helper class to check if there are new released versions for the app
    public static class VersionChecker
    {
        /// <summary>
        /// Gets the current app's version
        /// </summary>
        /// <returns>A string with the current number</returns>
        public static string GetCurrentVersion()
        {
            return Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        /// <summary>
        /// Checks the latest available version.
        /// </summary>
        /// <returns>
        /// Returns the latest version only if its newer than the current one. 
        /// If it's the same (or older, although that should'n happen) returns an empty string.
        /// If there's any error check for the version, returns a null.</returns>
        /// <remarks>
        /// It only gets the numbers and dots (eg: "v1.0.0" or "version 1.0.0" will only return "1.0.0".
        /// Only checks this once per day
        /// </remarks>
        public static string GetLatestAvailableVersion()
        {
            //Check the last time the chack was made
            DateTime lastChecked = Helper.GetLastVersionCheckDateTime();
            //if it's less than a day ago, do not check and return no new version available (empty string)
            if (DateTime.Now.Subtract(lastChecked).Days == 0)
                return string.Empty;

            string latestV = VersionChecker.GetLatestVersionFromGitHub("jmalarcon", "Win11ClockToggler");
            
            //Failed to get the latest version
            if (latestV == null) return null;

            //Save last time checked
            Helper.SaveLastVersionCheckDateTime();

            //Compare strings
            int comparison = string.Compare(latestV, GetCurrentVersion(), StringComparison.OrdinalIgnoreCase);
            if (comparison > 0)
                return latestV;
            else
                return string.Empty;
        }

        internal static string GetLatestVersionFromGitHub(string user, string repo)
        {
            try
            {
                string releasesInfo = ReadJsonUrl($"https://api.github.com/repos/{user}/{repo}/releases");
                //Since I only need the tag name to get the version, I directly get it in a lame and simple way: with a RegEx
                Regex versionRE = new Regex("\"tag_name\":\\s*\"\\D([\\d\\.]+?)\"", RegexOptions.IgnoreCase);
                Match m = versionRE.Match(releasesInfo);
                if (m.Success)
                    return m.Groups[1].Value;
            }
            catch
            {
            }
            //If we can't get the latest version, return null
            return null;
        }

        //Function to read an URL and return its contents as JSON
        private static string ReadJsonUrl(string url)
        {
            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.UserAgent, "Win11ClockToggler");   //Without this, the request returns a 403 (forbidden)
            string json = client.DownloadString(url);
            //Return the contents as a string
            return json;
        }

    }
}
