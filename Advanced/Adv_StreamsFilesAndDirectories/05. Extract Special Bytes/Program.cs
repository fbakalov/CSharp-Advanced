namespace ExtractSpecialBytes
{
    using System;
    using System.IO;
    using System.Linq;
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            using (var stream = new FileStream(binaryFilePath, FileMode.Open))
            {                
                using (StreamReader readerfile = new(bytesFilePath))
                {
                    byte[] bytesInFile = readerfile.ReadToEnd().Split(Environment.NewLine).Select(byte.Parse).ToArray();

                    byte[] buffer = new byte[stream.Length];

                    stream.Read(buffer, 0, buffer.Length);


                    using (StreamWriter writer = new(outputPath))
                    {
                        foreach (var bt in buffer)
                        {
                            if (bytesInFile.Contains(bt))
                            {
                                writer.WriteLine(bt);
                            }
                        }
                    }
                }
            }
        }
    }
}
