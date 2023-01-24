namespace LineNumbers
{
    using System;
    using System.IO;
    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            StreamReader reader = new(inputFilePath);
            StreamWriter writer = new(outputFilePath);

            using (reader)
            { 
                using (writer)
                {
                    int count = 1;

                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        int countLetters = 0;
                        int countSymbols = 0;
                        foreach (char ch in line)
                        {
                            if (Char.IsWhiteSpace(ch))
                            {
                                continue;
                            }

                            if (Char.IsLetter(ch))
                            {
                                countLetters++;
                            }
                            else if (!Char.IsDigit(ch))
                            {
                                countSymbols++;
                            }
                        }

                        writer.WriteLine($"Line {count}: {line} ({countLetters})({countSymbols})");
                        count++;
                    }
                }
            }
        }
    }
}
