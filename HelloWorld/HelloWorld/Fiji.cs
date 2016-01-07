using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Business
{
    class Fiji : HelloWorld
    {
        public Fiji(string name)
        {

            Greeting = "Bula";
            Name = name;
        }
        public override string ToString()
        {

            return ($"{Greeting} {Name} !!");

        }
    }
}
