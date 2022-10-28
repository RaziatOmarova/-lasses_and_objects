using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классы_и_объекты
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person raziyat = new Person();
            raziyat.name = "Raziyat";
            raziyat.age = 16;
            raziyat.Print();

            Console.WriteLine(Person.type);
            Console.ReadKey();
        }
    }
    class Person
    {
        public const string type = "Person";
        public string name;
        public int age;

        public void Print()
        {
            Console.WriteLine($"{type}: {name} - {age}");
        }
    }
}
