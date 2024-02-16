namespace Less3
{
    internal class Task1_3
    {
        /*Hаписать программу, ищущую среднее арифметическое значение из введенных аргументов,
         * передаваемых через параметры командной строки.*/
        static void Main1_3(string[] args)
        {
            int count = 0;
            int sum = 0;
            if (args.Length > 0)
            {
                
                foreach(var num in args)
                {
                    if(int.TryParse(num, out int num1))
                    {
                        count++;
                        sum += num1;
                    }
                    else
                    {
                        Console.WriteLine("Допустимы только числа");
                        return;
                    }
                }
            }
                Console.WriteLine($"Среднее арифметическое= {sum / count}");
        }
    }
}