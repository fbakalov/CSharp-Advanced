namespace MergeFiles
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            StreamReader readerInput1 = new(firstInputFilePath);
            StreamReader readerInput2 = new(secondInputFilePath);
            StreamWriter writer = new(outputFilePath);

            using (readerInput1)
            {
                using (readerInput2)
                {                   
                    using (writer)
                    {
                        List<string> list = readerInput1.ReadToEnd().Split(Environment.NewLine).ToList();
                        list.AddRange(readerInput2.ReadToEnd().Split(Environment.NewLine).ToList());
                        list.Sort();
                        foreach (var line in list)
                        {
                            writer.WriteLine(line);
                        }
                    }
                }
            }
        }
    }
}

