using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            PermanentEmployee pEmp = new PermanentEmployee();
            pEmp.EmpId = 1;
            pEmp.EmpName = "Akber Shah";
            pEmp.EmpAge = 25;
            pEmp.EmpMobile = 01825363652;
            pEmp.monthlySalary = 12500;
            pEmp.workingHoure = 7;
            pEmp.Get();
            Console.WriteLine(pEmp.EmpMobile);
            Console.ReadKey();
        }
    }
}
