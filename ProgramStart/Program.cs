using ProgramStart.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProgramStart
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Debug.WriteLine("start");

            var fileName = Path.GetFileName(Application.ExecutablePath);
            var rootDir = Path.GetDirectoryName(Application.ExecutablePath);

            Debug.WriteLine($"fileName: {fileName}");
            Debug.WriteLine($"rootDir: {rootDir}");

            var files = new List<FileItem>();

            foreach (var dir in Directory.EnumerateDirectories(rootDir))
            {
                var dirName = Path.GetFileName(dir);

                if (Regex.IsMatch(dirName, Resources.DirNamePattern))
                {
                    Debug.WriteLine($"+ {dirName}: {dir}");
                }
                else
                {
                    Debug.WriteLine($"- {dirName}: {dir}");

                    continue;
                }

                var file = Path.Combine(dir, fileName);

                Version version;

                if (File.Exists(file) && ((version = Utils.GetFileVersion(file)) != null))
                {
                    files.Add(new FileItem(file, version));
                }
            }

            if (files.Count == 0)
            {
                Debug.WriteLine("error: files not found");

                return;
            }

            files.Sort((a, b) => b.Version.CompareTo(a.Version));

            foreach (var file in files)
            {
                Debug.WriteLine($"{file.Version}: {file.FileName}");
            }

            var latest = files[0].FileName;

            try
            {
                var arguments = string.Join(" ", args);

                Debug.WriteLine($"start: {latest} {arguments}");

                Process.Start(latest, arguments);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }

            Console.WriteLine("done");
        }
    }
}