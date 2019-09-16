using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeLabbar
{
    class Lab3
    {
        /*3. Write a C# Sharp program to get the day of the week for a specified date.
             Expected Output :
             The day of the week for 7/11/2016 is Monday.
             3b – gör en ”svensk” variant av detta!!!*/
        public void Run()
        {
            DateTime datetime = new DateTime(2019,11,07);

             
            
            Console.WriteLine("The day of the week for {0:dd}/{0:MM}/{0:yyyy} is {1}.", datetime,datetime.DayOfWeek);
            Console.WriteLine("Veckodagen för {0:dd}/{0:MM}/{0:yyyy} är {0:dddd} ", datetime);
            Console.ReadLine();
        }
    }
}
