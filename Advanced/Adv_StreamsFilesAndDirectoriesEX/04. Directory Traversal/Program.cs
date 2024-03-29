﻿namespace DirectoryTraversal
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            SortedDictionary<string, List<FileInfo>> extensionsFiles = new();

            string[] files = Directory.GetFiles(inputFolderPath);

            foreach (var file in files)
            {
                FileInfo fileInfo = new(file);
                if (!extensionsFiles.ContainsKey(fileInfo.Extension))
                {
                    extensionsFiles.Add(fileInfo.Extension, new List<FileInfo>());
                }
                extensionsFiles[fileInfo.Extension].Add(fileInfo);
            }
            
            StringBuilder sb = new();

            foreach (var extensionFile in extensionsFiles.OrderByDescending(x => x.Value.Count))
            {
                sb.AppendLine(extensionFile.Key);

                foreach (var file in extensionFile.Value.OrderBy(x => x.Length))
                {
                    sb.AppendLine($"--{file.Name} - {(double)file.Length / 1024:f3}kb");
                }
            }
            return sb.ToString();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;
            File.WriteAllText(filePath, textContent);
        }
    }
}
