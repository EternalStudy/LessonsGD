using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LessonsGD.Seminars.Seminar2
{
    public class Task2_3
    {
        /*Даны массивы a и b, заполненные случайными числами. Необходимо создать массив c длиной,
         * равной сумме длин массивов a и b, заполнить его элементами массивов a и b,
         * отсортированными по возрастанию.*/
        public static void Main2_3(String[] args)
        {
            int[] a = { 9, 3, 4, 4, 5, 6, 1, 4, 7, 9, 0 };
            int[] b = { 1, 2, 3, 3, 9, 9, 1, 9, 9, 0, 0, 1, 1, 7 };
            Console.WriteLine(string.Join(',', Sorted(a,b)));
            Console.ReadKey();
        }
        private static int[] Sorted(int[] array1, int[] array2)
        {
            int[] newArray= new int[array1.Length + array2.Length];
            for(int i = 0; i < array1.Length; i++)
            {
                newArray[i] = array1[i];
            }
            for (int j = 0; j < array2.Length; j++)
            {
                newArray[j] = array2[j];
                j++;
            }
            Array.Sort(newArray);
            return newArray;
        }
    }
}
