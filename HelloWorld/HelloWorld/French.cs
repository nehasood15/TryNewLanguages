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
            Greeting = "Bonjour"; // renames the greeting in a particlar language
            Name = name;// assigns user entered name to the field Name of base class.
        }
        //public override string ToString()
        //{

        //    return ($"{Greeting} {Name} !!");

        //}
    }
}
