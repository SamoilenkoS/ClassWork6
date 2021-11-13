using System;

namespace Library
{
    public class ClassWork
    {
        public static int Power(int a, int b)
        {
            int result = a;
            for (int i = 1; i < b; i++)
            {
                result = result * a;
            }

            return result;
        }

        public static int[] NumbersDivisibleByA(int a)
        {
            int[] array = new int[1000 / a];
            for (int i = a, j = 0; i <= 1000; i += a)
            {
                array[j++] = i;
            }

            return array;
        }

        public static int Fibbonachi(int N)
        {
            int x1 = 1;
            int x2 = 1;
            for (; N > 2; N -= 2)
            {
                x1 += x2;
                x2 += x1;
            }

            return N == 1 ? x1 : x2;
        }

        public static int Divider(int a)
        {
            int result = 1;
            for (int i = a / 2; i > 1; i--)
            {
                if (a % i == 0)
                {
                    result = i;
                    break;
                }
            }

            return result;
        }

        public static int Sum(int a, int b)
        {
            int divider = 7;
            int result = 0;

            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            while (a % divider != 0)
            {
                ++a;
            }
            for (int i = a; i <= b; i += divider)
            {
                result += i;
            }

            return result;
        }

        public static int CubeRoot(int n)
        {
            int result = 0;
            if (n == 1)
            {
                return 1;
            }
            int currentRoot = n / 2;

            int previousRoot = 0;
            for (int i = 0; i < 30; i++)
            {
                decimal currentCube = (decimal)currentRoot * currentRoot * currentRoot;
                if (currentCube == n)
                {
                    result = currentRoot;
                    break;
                }
                else if (currentCube > n)
                {
                    previousRoot = currentRoot;
                    currentRoot /= 2;
                }
                else if (currentCube < n)
                {
                    currentRoot = (previousRoot + currentRoot) / 2;
                }
            }

            return result;
        }

        public static int IndexOf(int[] array, int searched)
        {
            int currentIndex = array.Length / 2;
            int previousIndex = array.Length - 1;
            while (currentIndex != 0 && currentIndex != (array.Length - 1))
            {
                if (array[currentIndex] == searched)
                {
                    return currentIndex;
                }
                else if (array[currentIndex] > searched)
                {
                    previousIndex = currentIndex;
                    currentIndex /= 2;
                }
                else
                {
                    currentIndex = (previousIndex + currentIndex) / 2 + (previousIndex + currentIndex) % 2;
                }
            }

            return array[currentIndex] == searched ? currentIndex : -1;
        }

        public static void MoveZerosToBeginning(int[] array)
        {
            int currentEmptyBox = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    int temp = array[currentEmptyBox];
                    array[currentEmptyBox++] = array[i];
                    array[i] = temp;
                }
            }
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void Reverse(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                Swap(ref array[i], ref array[array.Length - 1 - i]);
            }

        }

        public static int[] GetArrayWithElementsWhichAreMoreThanMedian(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            int median = sum / array.Length;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > median)
                {
                    count++;
                }
            }
            int[] resultArray = new int[count];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > median)
                {
                    resultArray[j++] = array[i];
                }
            }

            return resultArray;
        }

        public static bool IsOrdered(int[] array)
        {
            bool result = true;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}
