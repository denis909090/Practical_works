using System;
using System.Runtime.InteropServices.Marshalling;

namespace Project
{
    class IndividualTask_3
    {
        public static void variant_3()
        {
            Console.Write("Введіть рядок: ");
            string inputString = Console.ReadLine() ?? string.Empty;
            Console.Write("Введіть символ для вилучення: ");
            string removeChar = Console.ReadLine() ?? string.Empty;
            string resultString = inputString.Replace(removeChar, "");
            Console.WriteLine($"Результат: {resultString}");
        }
    }
}