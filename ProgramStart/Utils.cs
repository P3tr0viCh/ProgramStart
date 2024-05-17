using System.Diagnostics;
using System;

namespace ProgramStart
{
    internal class Utils
    {
        public static Version GetFileVersion(FileVersionInfo info)
        {
            try
            {
                return new Version(info.FileVersion);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            
            return null;
        }

        public static Version GetFileVersion(string filePath)
        {
            return GetFileVersion(FileVersionInfo.GetVersionInfo(filePath));
        }
    }
}