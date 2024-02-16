using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsGD.Seminars.Seminar2
{
    /*Дан двумерный массив. 
123
456
789
Выведите его на печать перевернутым на 90 градусов
741
852
963*/
    internal class Task2_5
    {
        public static void Main2_5(String[] args)
        {
            int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            
            int num1 = a.GetLength(0);
            int num2 = a.GetLength(1);
            int i = 0;
            

            while (i < num1)
            {
                int j = num2 - 1;
                while (j <= 0)
                {
                    Console.WriteLine($"{a[j, i]}");
                    j--;
                }
                i++;
                Console.WriteLine("");
            }
        }

    }
}
