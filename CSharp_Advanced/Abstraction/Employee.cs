using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Employee
    {
        public int EmpId;
        public string EmpName;
        public double GrossPay;
        double TaxDeduction = 0.1;
        double netSalary;
        public Employee(int Eid,string Ename, double EgrossPay)
        {
            this.EmpId = Eid;
            this.EmpName = Ename;
            this.GrossPay = EgrossPay;
        }
        void CalculateSalary()
        {
            if(GrossPay >= 30000)
            {
                netSalary = GrossPay - (TaxDeduction * GrossPay);
                Console.WriteLine($"Your net Salary is = { netSalary }");
            }
            else
            {
                Console.WriteLine($"Your net Salary is = { GrossPay }");
            }
        }
        public void ShowEmpDetails()
        {
            this.CalculateSalary();
        }

    }
}
