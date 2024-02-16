using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsGD.Seminars.Seminar2
{
    public class Task2_2
    {
        /*Написать программу, выводящую количество единиц в двоичном представлении числа.*/
        public static void Main2_2(String[] args)
        {
            Console.WriteLine("Введите число");
            byte num = byte.Parse(Console.ReadLine());
            int count = 0;
            while (num != 0)
            {
                if (num % 2 == 1)
                {
                    count++;
                }
                num /= 2;
            }
            Console.WriteLine(count);
        }
    }
}
