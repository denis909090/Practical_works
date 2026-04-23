using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Project
{
    class BaseTasks_4
    {
        // public static void task_2()
        // {
        //     Console.Write("Скільки чисел ви хочете ввести в масив? ");
        //     int n = int.Parse(Console.ReadLine() ?? string.Empty);
        //     int[] numbers = new int[n];
        //     int sum = 0;
        //     for (int i = 0; i < numbers.Length; i++)
        //     {
        //         Console.Write($"Введіть число {i + 1}: ");
        //         numbers[i] = int.Parse(Console.ReadLine() ?? string.Empty);
        //     }
        //     int min = numbers.Min();
        //     int max = numbers.Max();
        //     for (int i = 0; i < numbers.Length; i++)
        //     {
        //         if (numbers[i] == min || numbers[i] == max)
        //         {
        //             numbers[i] = 0;
        //         }
        //         sum += numbers[i];
        //     }
        //     Console.WriteLine(string.Join(", ", numbers));
        //     Console.WriteLine(sum);
        // }
        public static void task_3()
        {
            Console.Write("Введіть слово: ");
            string word = Console.ReadLine() ?? string.Empty;
            Console.WriteLine($"Ви ввели слово: {word}");
            string reversed = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word[i];
            }
            Console.WriteLine(reversed);
            string result = "";
            foreach (char c in word)
            {
                result += c + "*";
            }
            result = result.TrimEnd('*');
            Console.WriteLine(result);
        }

        public static void task_5()
        {
            Console.Write("Введіть кількість спортсменів (n): ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введіть кількість стрибків (m): ");
            string? s = Console.ReadLine();
            int m = int.Parse(s);
            double[,] results = new double[n, m];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nСпортсмен #{i + 1}:");
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"  Стрибок {j + 1}: ");
                    results[i, j] = double.Parse(Console.ReadLine());
                }
            }
            double[] sums = new double[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sums[i] += results[i, j];
                }
            }
            Console.WriteLine("Таблиця результатів");
            Console.Write("Спортсмен");
            for (int j = 0; j < m; j++)
                Console.Write($" Стрибок {j + 1}");
            Console.WriteLine(" Сума");
            Console.WriteLine(new string('-', 12 + m * 11 + 8));
            for (int i = 0; i < n; i++)
            {
                Console.Write($"    #{i + 1,-5} |");
                for (int j = 0; j < m; j++)
                    Console.Write($"   {results[i, j],5:F2}   |");
                Console.WriteLine($" {sums[i]:F2}");
            }
            int winnerIndex = 0;
            for (int i = 1; i < n; i++)
            {
                if (sums[i] > sums[winnerIndex])
                    winnerIndex = i;
            }
            Console.WriteLine("Результат");
            Console.WriteLine($"Переможець: спортсмен #{winnerIndex + 1}");
            Console.WriteLine($"Сума стрибків: {sums[winnerIndex]:F2} м");
        }
        public static void task_6()
        {
            string[,] users = {
            {"admin", "1234"},
            {"user1", "pass1"},
            {"user2", "pass2"}
        };

            Console.Write("Введіть логін: ");
            string login = Console.ReadLine();

            Console.Write("Введіть пароль: ");
            string password = Console.ReadLine();

            bool found = false;
            bool isAdmin = false;

            for (int i = 0; i < users.GetLength(0); i++)
            {
                if (login == users[i, 0] && password == users[i, 1])
                {
                    found = true;

                    if (login == "admin")
                        isAdmin = true;

                    break;
                }
            }

            if (found)
            {
                Console.WriteLine("Welcome");

                if (isAdmin)
                {
                    Console.WriteLine("Список користувачів:");
                    for (int i = 0; i < users.GetLength(0); i++)
                    {
                        Console.WriteLine($"Логін: {users[i, 0]}, Пароль: {users[i, 1]}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Goodbye");
            }
        }
    }
}
