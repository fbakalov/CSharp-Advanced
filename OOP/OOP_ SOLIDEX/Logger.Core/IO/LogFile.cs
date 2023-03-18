

using Logger.Core.Exeptions;
using Logger.Core.IO.Interfaces;
using System.Text;

namespace Logger.Core.IO
{
    public class LogFile : ILogFile
    {
        private const string DefaultExtension = "txt";
        private static readonly string DefaultName = $"Log_{DateTime.Now:dd-MM-yyyy HH-mm-ss tt}";
        private static readonly string DefaultPath = $"{Directory.GetCurrentDirectory()}";

        private string name;
        private string path;
        private string extension;

        private readonly StringBuilder content;

        public LogFile()
        {
            Name = DefaultName;
            Extension = DefaultExtension;
            Path = DefaultPath;

            content = new StringBuilder();
        }
        public LogFile(string name, string extension, string path)
            : this()
        {
            Name = name;
            Path = path;
            Extension = extension;    
        }

        public string Name 
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new EmptyFileNameExeption();
                }

                name = value;
            }
        }

        public string Extension
        {
            get => extension;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new EmptyFileExtensionExeption();
                }

                extension = value;
            }
        }

        public string Path
        {
            get => path;
            set
            {
                if(!Directory.Exists(value)) 
                {
                    throw new InvalidPathExeption();
                }
                path = value;
            }
        }

        public string FullPath => System.IO.Path.GetFullPath($"{Path}/{Name}.{Extension}");
        
        public string Content => content.ToString(); 

        public int Size => content.Length;
        

        public void WriteLine(string text)
            => content.AppendLine(text);
    }
}
