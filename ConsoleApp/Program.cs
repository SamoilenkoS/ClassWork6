using Library;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void TestIndexOf()
        {
            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i} {ClassWork.IndexOf(array, array[i])}");
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
