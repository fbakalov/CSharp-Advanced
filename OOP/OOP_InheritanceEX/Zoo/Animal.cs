using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Animal
    {
        private string name;

        public Animal(string name)
        {
            this.name = name;
        }

        public string Name { get; set; }
    }
}
