namespace EvenLines
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;
    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(string.Join(Environment.NewLine, ProcessLines(inputFilePath)));
        }

        public static List<string> ProcessLines(string inputFilePath)
        {
            List<string> lines = new();

            StreamReader streamReader = new(inputFilePath);            

            using (streamReader)
            {
                string line = streamReader.ReadLine();

                int count = 0;

                while (line != null)
                {
                    if (count % 2 == 0)
                    {
                        string[] words = line.Split();

                        List<string> fixedWords = new List<string>();

                        foreach (var word in words)
                        {
                            char[] chArr = word.ToCharArray();
                            for (int i = 0; i < chArr.Length; i++)
                            {
                                if (!Char.IsLetterOrDigit(chArr[i]))
                                {
                                    chArr[i] = '@';
                                }
                            }
                            fixedWords.Add(new string(chArr));
                        }

                        fixedWords.Reverse();
                        line = string.Join(" ", fixedWords);
                        lines.Add(line);          
                    }
                    line = streamReader.ReadLine();
                    count++;
                }
            }

            return lines;
        }
    }
}
