using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Resources;
using System.Configuration;

[assembly: System.Resources.NeutralResourcesLanguage("en")]

namespace HelloWorld.Business
{
   public class DisplayOptions
    {
        public string MenuParsing(string selection, string name)
        {
            if (int.Parse(selection) == 1)
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                return ($"{Resource.Lang.Greeting} {name} !!!");

            }

            else if (int.Parse(selection) == 2)
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fi");
                return ($"{Resource.Lang.Greeting} {name} !!!");

            }

            else if (int.Parse(selection) == 3)
            {

                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr");
                return ($"{Resource.Lang.Greeting} {name} !!!");

            }

            else if (int.Parse(selection) == 4)
            {

                return (ConfigurationManager.AppSettings["ExitMessage"]);

            }
            else
            {

                return (ConfigurationManager.AppSettings["ErrorMessage"]);
            }
        }


    }
}

