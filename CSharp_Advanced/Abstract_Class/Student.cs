using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Student : Persone
    {
        public int RollNumber;
        public double Fees;

        public override void PrintDetails()
        {
            string FullName = this.firstName + "" + this.lastName;
            Console.WriteLine($"Student Name is = { FullName }");
            Console.WriteLine($"Student age is = { this.Age }");
            Console.WriteLine($"Student mobile no is = { this.Mobile }");
            Console.WriteLine($"Student gender is = { this.Gender }");
            Console.WriteLine($"Student roll number is = { this.RollNumber }");
            Console.WriteLine($"Student fees is = { this.Fees }\n");
        }
    }
}
