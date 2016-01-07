using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Business
{
   public class DisplayOptions
    {
        public string MenuParsing(string selection, string name)
        {
            if (int.Parse(selection) == 1)
            {
                English egreet = new English(name);
                return (egreet.ToString());

            }

            else if (int.Parse(selection) == 2)
            {
                Fiji fijigreet = new Fiji(name);
                return (fijigreet.ToString());

            }

            else if (int.Parse(selection) == 3)
            {
                French frenchgreet = new French(name);
                return (frenchgreet.ToString());

            }
            else
            {

                return ("Invalid Selection!!!");
            }
        }


    }
}

