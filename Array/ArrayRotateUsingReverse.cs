using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public static class ArrayRotateUsingReverse
    {
        
        public static void rotate(int[] arr, int d, int n)
        {
            reverseArray(arr, 0, d-1);
            printArray(arr,n);
            reverseArray(arr, d, n);
            printArray(arr, n);
            reverseArray(arr, 0, n);
            printArray(arr, 7);
        }

        private static int[] reverseArray(int[] arr, int si, int li)
        {
            if (li == 1)
            {
                int temp = arr[0];
                arr[0] = arr[1];
                arr[1] = temp;
            }
            else
            {
                for (int i = si, j = li - 1; i != j; i++, j--)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            return arr;
        }

        private static void printArray(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine("\n");
        }

        #region [Test code for reverse algorithm]
        public static void reverseArray()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int si = 2;
            int li = 7;
            if (li == 1)
            {
                int temp = arr[0];
                arr[0] = arr[1];
                arr[1] = temp;
            }
            else
            {
                for (int i = si, j = li - 1; i != j; i++, j--)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            printArray(arr, 7);
            //return arr;
        }
        #endregion



    }
}
