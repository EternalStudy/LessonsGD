namespace Task4
{
    internal class Task1_4
    {/*Написать программу ищущую минимальное значение из введенных аргументов, передаваемых через параметры командной строки.*/
        static void Main1_4(string[] args)
        {
            int min = int.MaxValue;
            if(args.Length != 0)
            {
                foreach(var item in args)
                {
                    if(int.TryParse(item, out var value))
                    {
                        if (value < min) min = value;
                    }
                }
                Console.WriteLine($"Минимальное значение = {min}");
            }
        }
    }
}