namespace Less2
{
    internal class Task1_2
    {
        static void Main1_2(string[] args)
        {
            if (args.Length != 0)
            {
                int sum = 0;
                foreach (string arg in args)
                {

                    if (int.TryParse(arg, out int num))
                    {
                        sum += num;
                    }
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("Для использования программы введите 2 числа через пробел после имени программы");
            }

        }
    }
}