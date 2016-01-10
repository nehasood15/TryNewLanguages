using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Business;
using System.Configuration;

namespace HelloWorld.View
{
    class Program
    {
        static void Main(string[] args)
        {
            string selection;
            do
            {
                Console.WriteLine(ConfigurationManager.AppSettings["AskName"]);
                string name = Console.ReadLine().ToUpper();
                Console.WriteLine(ConfigurationManager.AppSettings["Options"]);
                selection = Console.ReadLine();
                DisplayOptions option = new DisplayOptions();
                Console.WriteLine(option.MenuParsing(selection, name));
                Console.ReadLine();
            } while (int.Parse(selection) != 4);

            Environment.Exit(0);

        }

    }
 }
    


