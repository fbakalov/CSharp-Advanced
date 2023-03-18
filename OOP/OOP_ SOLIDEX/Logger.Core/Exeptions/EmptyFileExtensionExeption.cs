using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Core.Exeptions
{
    public class EmptyFileExtensionExeption : Exception
    {
        private const string DefaultMessage = "File extension cannot be null or withespace";
        public EmptyFileExtensionExeption() : base(DefaultMessage)
        {
        }

        public EmptyFileExtensionExeption(string message)
            : base(message)
        {
        }
    }
}
