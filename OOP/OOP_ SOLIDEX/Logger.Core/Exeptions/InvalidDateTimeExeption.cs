using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Core.Exeptions
{
    public class InvalidDateTimeExeption : Exception
    {
        private const string DefaultMessage = "Invalid DateTime format";
        public InvalidDateTimeExeption() : base(DefaultMessage)
        {
        }

        public InvalidDateTimeExeption(string message)
            : base(message)
        {
        }
    }
}
