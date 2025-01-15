using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("今天是星期几？(输入一二三四五六七)");
            string date = Convert.ToString(DateTime.Now.DayOfWeek);
            Console.WriteLine(date.ToString());
            //string day = Console.ReadLine();
            switch (date)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                    Console.WriteLine("学习编程");
                    break;
                case "Thursday":
                case "Friday":
                case "Saturday":
                    Console.WriteLine("学习英语");
                    break;
                case "Sunday":
                    Console.WriteLine("休息");
                    break;
            }







        }
    }
}
