using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class Example<Type>
    {
        Type box;
        public Type data {
            set
            {
                this.box = value;
            }
            get
            {
                return this.box;
            }
        }

        //public Example(Type b)
        //{
        //    this.box = b;
        //}
        //public Type getBox()
        //{
        //    return this.box;
        //}
    }
}
