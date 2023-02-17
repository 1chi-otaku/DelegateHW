using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHW
{
    
    public class ArrayHandler
    {
        int[] array;

        public ArrayHandler(int[] array)
        {
            this.array = array;
        }
        public ArrayHandler(int numb)
        {
            this.array = new int[numb];
        }
        public void Random(int min, int max)
        {
            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(min, max);    
            }
        }
        public void Print()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        public static void PrintEvenElements(ArrayHandler arr)
        {
            Console.WriteLine("Even elements in the array: ");
            for (int i = 0; i < arr.array.Length; i++)
            {
                if (arr.array[i] % 2 == 0)
                    Console.Write(arr.array[i] + " ");
            }
            Console.WriteLine();
        }
        public static void PrintOddElements(ArrayHandler arr)
        {
            Console.WriteLine("ODD elements in the array: ");
            for (int i = 0; i < arr.array.Length; i++)
            {
                if (arr.array[i] % 2 != 0)
                    Console.Write(arr.array[i] + " ");
            }
            Console.WriteLine();
        }
        public static void PrintSimpleElements(ArrayHandler arr)
        {
            Console.WriteLine("Simple elements in the array: ");
            for (int i = 0; i < arr.array.Length; i++)
            {
                if (arr.array[i] > 1 && arr.array[i] % 2 != 0 && arr.array[i] % 3 != 0 && arr.array[i] % 5 != 0)
                    Console.Write(arr.array[i] + " ");
            }
            Console.WriteLine();
        }
        public static void PrintFibonacciElements(ArrayHandler arr)
        {
            Console.WriteLine("Fibonacci elements in the array: ");
            for (int i = 0; i < arr.array.Length; i++)
            {
                int f1 = 1, f2 = 1, it = 2;
                while (f2 < arr.array[i])
                {
                    int tmp = f2;
                    f2 += f1;
                    f1 = tmp;
                    it++;
                }
                if (f2 == arr.array[i])
                {
                    Console.Write(arr.array[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
    public delegate void ArrayDel(ArrayHandler array);
}
