using System;

namespace Project.lab_1
{
    class lab_tasks
    {
        public static void task_1()
        {
            Console.WriteLine("Лабораторна робота №1 Гирман Денис");
            double x = 0.465;
            double y = 6.33;
            double z = 3.25;
            double b = 0.81;

            double v = 5 * (Math.Atan(z));
            double u = (3 * (x - y)) / (Math.Pow(z, 2) + Math.Pow(x, 2));
            double r = 1 + (Math.Pow(z, 2) / (3 + (Math.Pow(z, 2) / 5))) + Math.Asin(z / 4);
            double k = Math.Sqrt(Math.Pow(b, 3) + Math.Pow(Math.Cos(x), 2));
            Console.WriteLine($"v = {v}");
            Console.WriteLine($"u = {u}");
            Console.WriteLine($"r = {r}");
            Console.WriteLine($"k = {k}");
        }

        public static void task_2()
        {
            Console.Title = "Лабораторна робота No1 Гирман Денис";

            try
            {
                Console.WriteLine("Напишіть число для x");
                double x = double.Parse(Console.ReadLine() ?? "0");
                Console.WriteLine("Напишіть число для y");
                double y = double.Parse(Console.ReadLine() ?? "0");
                double z = 3.25;
                double b = 0.81;
                double v = 5 * (Math.Atan(z));
                double u = (3 * (x - y)) / (Math.Pow(z, 2) + Math.Pow(x, 2));
                double r = 1 + (Math.Pow(z, 2) / (3 + (Math.Pow(z, 2) / 5))) + Math.Asin(z / 4);
                double k = Math.Sqrt(Math.Pow(b, 3) + Math.Pow(Math.Cos(x), 2));
                Console.WriteLine($"v = {v}");
                Console.WriteLine($"u = {u}");
                Console.WriteLine($"r = {r}");
                Console.WriteLine($"k = {k}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }
    }
}
