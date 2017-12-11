using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    // Overriding parent functions
    // Object is the parent class for everything
    // generics
    // constraints
    // operator+ kindof

    class Program
    {
        static int add(int firstInt, int secondInt)
        {
            return firstInt + secondInt;
        }

        static float add(float firstFloat, float secondFloat)
        {
            return firstFloat + secondFloat;
        }

        static void Print<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            Print(nums);

            Console.WriteLine(add(1, 2));
            Console.WriteLine(add(1.5f, 3.8f));
            Console.WriteLine(add(1, 2.5f));
            Console.WriteLine(add(1.5f, 2.8f));
            Console.ReadKey();
        }
    }
}
