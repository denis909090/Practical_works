using System;

namespace Project
{
    class BaseTasks_2
    {
        public static void task_3()
        {
            Console.WriteLine("Гирман Денис");

            Console.Write("Введіть число A:");
            double A = double.Parse(Console.ReadLine() ?? string.Empty);
            double X = (A + 9.32) / 6.42;
            Console.WriteLine($"X = {X}");
            double Y;
            if (X > 2 && X < 8)
            {
                Y = Math.Exp(X + 1);
                Console.WriteLine($"Y = {Y}");
            }
            else if (X <= 2 || X > 15)
            {
                Y = (-3 * X) + 8;
                Console.WriteLine($"Y = {Y}");
            }
            else if (X >= 8 && X <= 15)
            {
                Y = Math.Abs((3 * X) - 5.5);
                Console.WriteLine($"Y = {Y}");
            }
        }
        public static void task_4()
        {
            Console.WriteLine("Гирман Денис");
            Console.Write("Введіть час (години):");
            int hours = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.Write("Введіть час (хвилини):");
            int minutes = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine($"Час за 24-часовим форматом: {hours}:{minutes}");
            string period = hours < 12 ? "AM" : "PM";
            if (hours > 12)
            {
                period = "PM";
            } else
            {
                period = "AM";
            }
            int hours12 = hours % 12;
            Console.WriteLine($"Час за 12-часовим форматом: {hours12}:{minutes} {period}");
        }
    }
}
