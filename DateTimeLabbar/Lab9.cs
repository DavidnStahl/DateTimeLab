using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeLabbar
{
    class Lab9
    {
        /*9. Write a program in C# Sharp to check whether the given year, month and day are today or not.
            Test Data :
            Input the Day : 06
            Input the Month : 09
            Input the Year : 2019
            Expected Output :
            Detta är idag! Eller Detta är INTE idag*/

        public void Run()
        {


            DateTime today = DateTime.Now;

            var yearToday = String.Format("{0:yyyy}", today);
            var monthToday = String.Format("{0:MM}", today);
            var dayToday = String.Format("{0:dd}", today);

            Console.Write("Input the Day: ");
            var day = Console.ReadLine();
            Console.Write("Input the Month: ");
            var month = Console.ReadLine();
            Console.Write("Input the Year: ");
            var year = Console.ReadLine();

            if (day == dayToday && month == monthToday && year == yearToday)
            {
                Console.WriteLine("Detta är idag!");
            }
            else
            {
                Console.WriteLine("Detta är INTE idag!");
            }
            Console.ReadLine();

            




        }
    }
}
