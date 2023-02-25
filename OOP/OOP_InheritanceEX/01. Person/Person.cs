using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonNamespace;

public class Person
{
    private string name;
    private int age;
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public string Name { get { return name; } set { name = value; } }
    public int Age { get { return age;} set { age = value; } }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(String.Format($"Name: {this.name}, Age: {this.age}"));
        return sb.ToString();
    }
}
