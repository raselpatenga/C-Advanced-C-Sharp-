using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Employee
    {
        public static Type showArray <Type> (Type firstInput, Type secondInput)
        {
            dynamic data1 = firstInput, data2 = secondInput;
            return data1 + data2;
        }
    }
}
