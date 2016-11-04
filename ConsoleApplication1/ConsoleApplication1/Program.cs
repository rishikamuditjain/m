using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Solution
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            String elements = Console.ReadLine();
            String[] split_elements = elements.Split(' ');
            for (int i = 0; i < size; i++)
            {
                array[i] = Convert.ToInt32(split_elements[i]);
            }

            quickSort(array, 0, array.Length - 1);
        }

        static void quickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = partition(array, low, high);

                quickSort(array, low, pi - 1);
                quickSort(array, pi + 1, high);
            }
        }

        static int partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = (low - 1);
            for (int j = low; j <= high - 1; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    swap(array, i, j);
                }
            }
            swap(array, i + 1, high);
            printArray(array);
            return i + 1;
        }

        static void swap(int[] array, int first, int second)
        {
            int temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }

        static void printArray(int[] array)
        {
            foreach (int nn in array)
            {
                Console.Write(nn + " ");
            }
            Console.WriteLine();
        }
    }
}
