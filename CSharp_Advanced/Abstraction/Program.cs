using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Remon = new Employee(101, "Atik ullah", 25000);
            Remon.ShowEmpDetails();
            Console.ReadKey();
        }
    }
}
