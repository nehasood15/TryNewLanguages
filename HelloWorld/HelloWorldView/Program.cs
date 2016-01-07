using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Business;

namespace HelloWorld.View
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Enter Name");
                string name = Console.ReadLine().ToUpper();

                Console.WriteLine("Please select following choices 1. Greet in English 2. Greet in Fiji 3. Greet in French");

                string selection = Console.ReadLine();

                DisplayOptions option = new DisplayOptions();
                Console.WriteLine(option.MenuParsing(selection, name));

                Console.ReadLine();


            }
        }
    }


