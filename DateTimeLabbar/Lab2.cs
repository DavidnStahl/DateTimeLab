using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeLabbar
{
    class Lab2
    {
        /*2. Write a C# Sharp program to display the Day properties (year, month, day, hour, minute,
             second, millisecond etc.).
             Expected Output :
                year = 2016
                month = 8
                day = 16
                hour = 3
                minute = 57
                second = 32
                millisecond = 11 */
        public void Run()
        {
            DateTime today = DateTime.Now;
            var year = String.Format("{0:yyyy}", today);
            var month = String.Format("{0:MM}", today);
            var day = String.Format("{0:dd}", today);
            var hour = String.Format("{0:hh}", today);
            var minute = String.Format("{0:mm}", today);
            var second = String.Format("{0:ss}", today);
            var millisecond = String.Format("{0:ffff}", today);
            Console.WriteLine($"year = {year}\nmonth = {month}\nday = {day}\nhour = {hour}\nminute = {minute}\nsecond = {second}\nmillisecond = {millisecond}");
            Console.ReadLine();
            




        }
    }
}
