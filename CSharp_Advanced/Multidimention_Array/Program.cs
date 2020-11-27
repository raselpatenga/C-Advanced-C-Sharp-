using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimention_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] my_array = new int[3, 4]
            {
                {11, 12, 13, 14 },
                {15, 16, 17, 18 },
                {19, 20, 21, 22 }
            };

            for (int i = 0; i < my_array.GetLength(0); i++)
            {
                for (int j = 0; j < my_array.GetLength(1); j++)
                {
                    Console.Write(my_array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
