namespace Seminars
{
    public class Task1_1
    {
        /*модифицировать программу-калькулятор таким образом,
         * чтобы она проверяла количество введенных аргументов и,
         * в случае если оно равно 2, выводила в консоль результат их сложения;
         * если же количество аргументов отличается,
         * выводила инструкцию по использованию программы.*/
        public static void Main1_1(String[] args)
        {
            if (args.Length==2)
            {
                if(int.TryParse(args[0], out int num1) && int.TryParse(args[1], out int num2))
                {
                    Console.WriteLine(num1 + num2);
                }
            }
            else
            {
                Console.WriteLine("Для использования программы введите 2 числа через пробел после имени программы");
            }
        }
    }
}