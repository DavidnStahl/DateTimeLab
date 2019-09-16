using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeLabbar
{
    class Lab7
    {
        //7. . Write a C# Sharp program to get the number of days of the specified month and year.
        public void Run()
        {
            const int July = 7;

            int daysInJuly = DateTime.DaysInMonth(1977, July);            Console.WriteLine(daysInJuly);            Console.ReadLine();                                          

        }
    }
}
