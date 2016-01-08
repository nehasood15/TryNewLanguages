using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Business
{
    class HelloWorld
    {
       protected string Greeting ;
       protected string Name;
        //TODO define more fields to enhance later


        public override string ToString()
        {
            return ($"{Greeting} {Name} !!"); // returning string Hello concatenated with name
        }



    }

}
