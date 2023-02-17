using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHW
{
    class Program
    {
        public delegate void DateDel();
        public delegate void FigureDel(int a, int b);
        static void Main(string[] args)
        {
            #region #1
            //ArrayHandler array = new ArrayHandler(5);

            //array.Random(10,99);
            //array.Print();

            //ArrayDel functions = new ArrayDel(ArrayHandler.PrintEvenElements);
            //functions += ArrayHandler.PrintOddElements;
            //functions += ArrayHandler.PrintSimpleElements;
            //functions += ArrayHandler.PrintFibonacciElements;

            //functions(array);

            #endregion

            #region #2

            DateDel DateFunctions = new DateDel(Date.ShowCurrentDate);
            DateFunctions += Date.ShowDayofWeek;
            DateFunctions += Date.ShowCurrentTime;
            DateFunctions();
            FigureDel FigureFunctions = new FigureDel(Figure.GetTriangleArea);
            FigureFunctions += Figure.GetRectangleArea;
            FigureFunctions(5,2);
            #endregion

        }
    }
}
