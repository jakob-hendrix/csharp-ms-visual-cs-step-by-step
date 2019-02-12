using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person jakob = new Person("Jakob Hendrix", 30);
            Console.WriteLine(jakob);

            Object somebody = jakob;
            Console.WriteLine(somebody);

            jakob = (Person)somebody;

        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }

            public override string ToString()
            {
                return $"This is a person named {this.Name} whom is {this.Age} years old.";
            }
        }
    }
}
