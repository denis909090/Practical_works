using System;

namespace Project
{
    class individual_tasks
    {
        public static void task_1()
        {
            Console.WriteLine("Введіть ціле число:");
            int n = int.Parse(Console.ReadLine() ?? "0");
            int nextEven = n + 2 - (n % 2);
            Console.WriteLine("Наступне парне число: {0}", nextEven);
        }

        public static void task_2()
        {
            Console.WriteLine("Введіть дату народження:");
            int n = int.Parse(Console.ReadLine()?? "0");
            Console.WriteLine($"Cтуденту {DateTime.Now.Year - n} повних років");
        }

        public static void task_3()
        {
            Console.WriteLine("Введіть перше ціле число:");
            int n1 = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Введіть друге ціле число:");
            int n2 = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine($"Сума: {n1 + n2}");
            Console.WriteLine($"Різниця: {n1 - n2}");
            Console.WriteLine($"Добуток: {n1 * n2}");
            Console.WriteLine($"Степінь числа {n1}: {Math.Pow(n1, n2)}");
            Console.WriteLine($"Степінь числа {n2}: {Math.Pow(n2, n1)}");
        }

        public static void task_4()
        {
            Console.WriteLine("Введіть перше ціле число:");
            int n1 = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Введіть друге ціле число:");
            int n2 = int.Parse(Console.ReadLine() ?? "0");
            if (n2 != 0)
            {
                Console.WriteLine($"Частка: {n1 / n2}");
            }
            else
            {
                Console.WriteLine("Друге число не може бути нулем");
            }
        }

        public static void task_5()
        {
            Console.WriteLine("Скільки чисел хочете ввести?");
            int num_count = int.Parse(Console.ReadLine() ?? "0");
            double sum = 0;

            for (int i = 1; i <= num_count; i++)
            {
                Console.WriteLine($"Введіть число {i}:");
                int n = int.Parse(Console.ReadLine() ?? "0");
                sum += n;
            }
            Console.WriteLine($"Середнє арифметичне: {sum / num_count}");
        }

        public static void task_6()
        {
            Console.WriteLine("Введіть ваш зріст в см:");
            double height = double.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine($"Ваш зріст: {height} см");
            Console.WriteLine($"Ваш оптимальна вага: {height - 100} кг");
        }

        public static void task_7()
        {
            Console.WriteLine("Введіть радіус кола:");
            double radius = double.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine($"Довжина кола: {radius * 2 * Math.PI}");
            Console.WriteLine($"Площа кола: {Math.Pow(radius, 2) * Math.PI}");
        }
    }
}
