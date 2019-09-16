using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DateTimeLabbar
{
    class Lab6
    {
        /*6. Write a program letting the user input a date in format 2012-02-18 and you should convert it
            (Google DateTime.Parse, ParseExact) to a datetime*/

        public void Run()
        {
            while (true)
            {
                Console.Write("Ange datum:");
                string input = Console.ReadLine();
                DateTime dt;



                bool ok = DateTime.TryParseExact(input, "yyyy-MM-dd",
                    CultureInfo.CurrentCulture,
                    DateTimeStyles.None, out dt);
                
                    if (ok)
                    {
                        Console.WriteLine((String.Format("{0:d}", dt)));
                    Console.WriteLine("Rätt inmatat datum!!");
                    Console.ReadLine();
                    break;
                    }
                
                    if (!ok) Console.WriteLine("fel input av datum försök igen");
                Console.ReadLine();
            }
            
                




        }
        
    }
}
