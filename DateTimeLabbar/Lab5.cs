using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeLabbar
{
    class Lab5
    {
        /*5, Skriv ett C# program som loopar 10 gånger och lägger till 40 dagar till tidigare
             datum (börja med dagens)*/
        public void Run()
        {
            DateTime today = DateTime.Now;
            int addDays = 40;
            int loopadddays = 0;
            
            

            for (int i = 0; i < 10; i++)
            {
                
                if (i == 0) Console.WriteLine((String.Format("{0:d}", today)));
                if (i > 0)
                {
                    loopadddays += addDays;
                    Console.WriteLine((String.Format("{0:d}", today.AddDays(loopadddays))));
                    
                }
                

            }
            Console.ReadLine();
        }
    }
}
