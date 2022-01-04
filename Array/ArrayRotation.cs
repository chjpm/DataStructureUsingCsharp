using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
 /*
     Input arr[] = [1, 2, 3, 4, 5, 6, 7], d = 2, n =7
1) Store the first d elements in a temp array
   temp[] = [1, 2]
2) Shift rest of the arr[]
   arr[] = [3, 4, 5, 6, 7, 6, 7]
3) Store back the d elements
   arr[] = [3, 4, 5, 6, 7, 1, 2]
 */
    public static class ArrayRotation
    {
        public static void usingTempVariable(int[] arr, int d, int n)
        {
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("Original Array: ");
            printArray(arr, n);
            leftRotateArray(arr, d, n);

            void leftRotateArray(int[] arr, int d, int n)
            {

                for (int i = 0; i < d; i++)
                {
                    Console.WriteLine("\nPrinting Array({0})", i + 1);
                    rotateOneByOne(arr, d, n);
                }
                Console.ReadLine();
            }

            void rotateOneByOne(int[] arr, int d, int n)
            {
                int temp = arr[0];
                for (int i = 0; i < n - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[n - 1] = temp;

                printArray(arr, n);
            }

            void printArray(int[] arr, int n)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(arr[i]);
                }
                Console.WriteLine();
            }
        }

        public static void usingArrayReverse(int[] arr, int d, int n)
        {
            reverseArray(arr, 0, d - 1);
            printArray(arr, n);
            reverseArray(arr, d, n);
            printArray(arr, n);
            reverseArray(arr, 0, n);
            printArray(arr, 7);

            int[] reverseArray(int[] arr, int si, int li)
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
            void printArray(int[] arr, int n)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(arr[i]);
                }
                Console.WriteLine("\n");
            }
        }

        


    }
}
