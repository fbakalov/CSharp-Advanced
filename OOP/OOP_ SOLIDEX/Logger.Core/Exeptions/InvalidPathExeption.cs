using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Core.Exeptions
{
    public class InvalidPathExeption : Exception
    {
        private const string DefaultMessage = "Path is invalid or empty";
        public InvalidPathExeption() : base(DefaultMessage)
        {
        }

        public InvalidPathExeption(string message)
            : base(message)
        {
        }
    }
}
