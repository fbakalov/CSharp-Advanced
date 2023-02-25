using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            return !this.Any();
        }

        public void AddRange(IEnumerable<string> values)
        {
            foreach (string value in values) { this.Push(value); }
        }
    }
}
