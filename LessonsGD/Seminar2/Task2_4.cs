using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsGD.Seminars.Seminar2
{
    public class Task2_4
    {/*Найти в строке с текстом подстроку с числами (такая подстрока всего одна).
      string s = "Эта строка содержит числа 12345 в своей середине";*/
        public static void Main2_4(String[] args)
        {
            string info = "Это строка содержит числа 12345 в своей середине";
            StringBuilder sb = new StringBuilder();
            bool check = false;
            for (int i = 0; i < info.Length; i++)
            {
                if (char.IsDigit(info[i]))
                {
                    check = true;
                }
                if (check) sb.Append(info[i]);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
