namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            int n = 10;
            int count = 0;
            int a = 0;
            int b = 1;

            while (count < n)
            {
                int next = a + b;
                a = b;
                b = next;
                count++;
                Console.WriteLine();
            }

            //2
            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i);

            }

            //3
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine($"Таблица умножения на {i}");
                for (int x = 1; x < 10; x++)
                {
                    Console.WriteLine($"{x} * {i} = {x * i}");
                }

            }

            //4
            string password = "qwerty";
            string userInput;
            do
            {
                Console.Write("Введите пароль");
                userInput = Console.ReadLine()!;

            }
            while (userInput != password);
        }




        }

    }


            