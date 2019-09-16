using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeLabbar
{
    class Lab1
    {
        /*1. Skriv ett program som tar fram aktuell datum och tid och skriver ut
             Expected Output:
             Complete date: 2019-09-06 12:15:00
             Short Date: 2019-09-06
             tips (DateTime.ToString() ??? )*/

        public void Run()
        {
            DateTime today = DateTime.Now;
            var todayTime = today.ToString();
            var d = String.Format("{0:d}", today);
            
            
            Console.WriteLine($"Complete date: {todayTime}\nShot Date: {d}");
            Console.ReadLine();
        }

    }
}
