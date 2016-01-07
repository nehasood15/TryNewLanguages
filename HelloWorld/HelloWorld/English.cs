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
            Name = name;
        }
       public override string ToString()
        {
         
            return ($"{Greeting} {Name} !!");

        }
    }
}
