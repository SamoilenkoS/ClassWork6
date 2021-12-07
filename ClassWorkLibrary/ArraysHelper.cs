using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWorkLibrary
{
    public class ArraysHelper
    {
        public static void Sort(int[] array)
        {
            if(array == null)
            {
                throw new ArgumentNullException
                    (nameof(array), "Array is null!");
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if(array[i] > array[j])
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
