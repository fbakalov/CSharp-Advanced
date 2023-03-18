using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Core.Exeptions
{
    public class EmptyMassageTextExeption : Exception
    {
        private const string DefaultMessage = "Created message text cannot be null or withespace";
        public EmptyMassageTextExeption() : base(DefaultMessage)
        {
        }

        public EmptyMassageTextExeption(string message)
            : base(message)
        {
        }
    }
}
