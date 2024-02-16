using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsGD.Seminars.Seminar2
{
    /*Написать программу, подсчитывающую количество чисел от 0 до 1000, делящихся на 3 без остатка.*/
    public class Task2_1
    {
        public static void Main2_1(String[] args)
        {
            int count = 0;
            for (int i = 0; i <= 1000;i+=3)
            {
                /*if (i % 3 == 0)
                {
                    count++;  
                }*/
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
