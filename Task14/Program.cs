using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Мурка", "Мяу");
            cat.ShowInfo();
            Dog dog = new Dog("Босфор");
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
}
