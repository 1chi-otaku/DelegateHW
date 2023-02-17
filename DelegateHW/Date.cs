using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHW
{
    public class Date
    {

        public static void ShowCurrentTime() => Console.WriteLine(DateTime.Now.ToString("hh:mm:ss tt"));
        public static void ShowCurrentDate() => Console.WriteLine(DateTime.Now);
        public static void ShowDayofWeek() => Console.WriteLine(DateTime.Now.ToString("dddd"));
    }

    public class Figure
    {
        public static void GetTriangleArea(int a, int h)
        {
            Console.WriteLine(0.5 * (a + h));
        }
        public static void GetRectangleArea(int a, int b)
        {
            Console.WriteLine(a * b);
        }
    }
}
