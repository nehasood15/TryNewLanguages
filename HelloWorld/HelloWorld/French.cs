using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Business
{
    class French : HelloWorld
    {

        public French(string name)
        {
            Greeting = "Bonjour";
            Name = name;
        }
        public override string ToString()
        {

            return ($"{Greeting} {Name} !!");

        }
    }
}
