using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    abstract class Persone
    {
        public int Id;
        public string firstName;
        public string lastName;
        public int Age;
        public string Mobile;
        public string Gender;
        public abstract void PrintDetails();
    }
}
