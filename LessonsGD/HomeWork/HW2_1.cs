using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsGD.HomeWork
{
    internal class HW2_1
    {
        public static void Main(string[] args)
        {
            int[,] a = { { 7, 3, 2 },
                         { 4, 9, 6 },
                         { 1, 8, 5 } };
            int[] mass = new int[a.Length];
            int counter = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    mass[counter] = a[i, j];
                    counter++;
                }
            }
            Array.Sort(mass);
            counter = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i,j] = mass[counter];
                    counter++;
                    Console.WriteLine(a[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
