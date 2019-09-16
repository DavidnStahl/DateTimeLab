using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeLabbar
{
    class Lab8
    {
        /*8. Write a C# Sharp program to get the difference between two dates in days.
             Expected Output :
             Difference in days: 2253*/

        public void Run()
        {
            DateTime startDate = new DateTime(2019, 09, 11);
            DateTime endDate = new DateTime(2025, 01, 01);

            TimeSpan difference = endDate - startDate;
            Console.WriteLine("Difference in days: " + difference.Days);
            Console.ReadLine();


        }
    }
}
