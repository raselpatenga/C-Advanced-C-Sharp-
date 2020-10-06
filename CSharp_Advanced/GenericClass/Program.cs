using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Example<int> number = new Example<int>();
            Example<string> name = new Example<string>();
            number.data = 20;
            name.data = "Adil Khan";

            Console.WriteLine(number.data);
            Console.WriteLine(name.data);
            Console.ReadKey();
        }
    }
}
