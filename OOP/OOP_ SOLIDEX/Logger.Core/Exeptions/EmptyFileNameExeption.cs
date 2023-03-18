using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Core.Exeptions
{
    public class EmptyFileNameExeption : Exception
    {
        private const string DefaultMessage = "File name cannot be null or withespace";
        public EmptyFileNameExeption() : base(DefaultMessage)
        {
        }

        public EmptyFileNameExeption(string message)
            : base(message)
        {
        }
    }
}
