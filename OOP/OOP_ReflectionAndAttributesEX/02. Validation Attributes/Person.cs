

using _02._Validation_Attributes.Attributes;
using ValidationAttributes.Attributes;

namespace ValidationAttributes
{
    public class Person
    {
        public Person(string name, int age)
        {
            FullName = name;
            Age = age;
        }

        [MyRequired]
        public string FullName { get; set; }

        [MyRange(12, 90)]
        public int Age { get; set; }
    }
}
