namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            StreamReader readerOfWords = new StreamReader(wordsFilePath);
            StreamReader readerOfText = new StreamReader(textFilePath);

            StreamWriter writer = new StreamWriter(outputFilePath);

            Regex regex = new Regex("[*'\",_&#^@!?.-]");

            using (readerOfWords)
            {
                using (readerOfText)
                {
                    Dictionary<string, int> repeatingWords = new();

                    string[] text = regex.Replace(readerOfText.ReadToEnd(), string.Empty).ToLower().Split();

                    string[] wordsToCount = readerOfWords.ReadToEnd().ToLower().Split();

                    foreach (string word in text)
                    {
                        if (wordsToCount.Contains(word))
                        {
                            if (!repeatingWords.ContainsKey(word))
                            {
                                repeatingWords.Add(word, 0);
                            }
                            repeatingWords[word]++;
                        }                       
                    }

                    repeatingWords = repeatingWords.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                    using (writer)
                    {
                        foreach (var item in repeatingWords)
                        {
                            writer.WriteLine($"{item.Key} - {item.Value}");
                        }
                    }
                }
            }
        }
    }
}