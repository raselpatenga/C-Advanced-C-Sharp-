using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Remon = new Student();
            Remon.firstName = "Atil";
            Remon.lastName = "ullah";
            Remon.Age = 17;
            Remon.Mobile = "01625253214";
            Remon.RollNumber = 25;
            Remon.Gender = "Male";
            Remon.Fees = 1600;
            Remon.PrintDetails();

            Teacher Anower = new Teacher();
            Anower.firstName = "Anower";
            Anower.lastName = "ullah";
            Anower.Age = 30;
            Anower.Mobile = "01822339363";
            Anower.Gender = "Male";
            Anower.qualification = "BSC-Engineering(CSS)";
            Anower.Salary = 75000;
            Anower.PrintDetails();

            Console.ReadKey();
        }
    }
}
