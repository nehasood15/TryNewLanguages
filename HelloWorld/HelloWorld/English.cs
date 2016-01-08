using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Business
{
    class English : HelloWorld
    {

        public English(string name)
        {
            Greeting = "Hello";
            Name = name; // assigns user entered name to the field Name of base class.
        }
       //public override string ToString()
       // {

       //     return base.ToString();
       // }
    }
}
