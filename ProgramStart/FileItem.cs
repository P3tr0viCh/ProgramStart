using System;

namespace ProgramStart
{
    internal class FileItem
    {
        public FileItem(string fileName, Version version)
        {
            FileName = fileName;
            Version = version;
        }

        public string FileName { get; set; }
        public Version Version { get; set; }
    }
}