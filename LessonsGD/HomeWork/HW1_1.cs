using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsGD.HomeWork
{
    internal class HW1_1
    {
        public static void Main1_1(string[] args)
        {
            Console.WriteLine("Введите два числа");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите символ действия с числами? Сложить, вычесть, разделить или умножить?");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Сложение {a} + {b}= {a + b}");
                    break;
                case "-":
                    Console.WriteLine($"Вычитание {a} - {b}= {a - b}");
                    break;
                case "*":
                    Console.WriteLine($"Умножение {a} * {b}= {a * b}");
                    break;
                case "/":
                    Console.WriteLine($"Деление {a} / {b}= {a / b}");
                    break;
            }

        }
    }

}

