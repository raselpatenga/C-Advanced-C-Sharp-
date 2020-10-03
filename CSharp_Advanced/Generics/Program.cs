using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            string[] inputs = Console.ReadLine().Split(' ');
            Console.WriteLine(Employee.showArray(numbers[0], numbers[1]));
            Console.WriteLine(Employee.showArray(inputs[0], inputs[1]));
            Console.ReadKey();
        }
    }
}
