using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Teacher : Persone
    {
        public string qualification;
        public double Salary;

        public override void PrintDetails()
        {
            string FullName = this.firstName + "" + this.lastName;
            Console.WriteLine($"Teacher Name is = { FullName }");
            Console.WriteLine($"Teacher age is = { this.Age }");
            Console.WriteLine($"Teacher mobile no is = { this.Mobile }");
            Console.WriteLine($"Teacher gender is = { this.Gender }");
            Console.WriteLine($"Teacher roll number is = { this.qualification }");
            Console.WriteLine($"Teacher fees is = { this.Salary }\n");
        }
    }
}
