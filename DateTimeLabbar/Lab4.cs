using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeLabbar
{
    class Lab4
    {
        /*4. Write a C# Sharp program to calculate what day of the week is 40 days from this moment
             Expected Output :
             Today = 8/20/2016 4:18:17 PM
             Thursday */
        public void Run()
        {
            DateTime today = DateTime.Now;
            DateTime in40days = today.AddDays(40);
            
            Console.WriteLine("Today = {0}",today);
            Console.WriteLine(in40days.DayOfWeek);
            Console.ReadLine();


        }
    }
}
