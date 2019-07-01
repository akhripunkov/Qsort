using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qsort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 5, 332, 1, 3, 5, 78, 3 };

            WriteIntArray(arr); //печать массива в строку
            quicksort(arr, 0, arr.Length - 1); // быстрая сортировка
            Console.WriteLine();
            WriteIntArray(arr);
            Console.ReadKey();
        }

        public static void WriteIntArray(int[] array) 
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i]);
            }
        } //печать массива в строку

        public static int partition(int[] array, int start, int end)
        {
            int temp;
            int marker = start;
            for (int i = start; i <= end; i++)
            {
                if (array[i] < array[end]) 
                {
                    temp = array[marker]; 
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }
            temp = array[marker];
            array[marker] = array[end];
            array[end] = temp;
            return marker;
        } //деление на части

        public static void quicksort(int[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int pivot = partition(array, start, end);
            quicksort(array, start, pivot - 1);
            quicksort(array, pivot + 1, end);
        } // функция сортировки

    }
}
