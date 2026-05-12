using System;

class Lab6
{
    public static int BinarySearch(double[] arr, double target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (arr[mid] == target)
            {
                return mid;
            }
            else if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }

    public static void Run()
    {
        double[] arr = new double[20];
        Random rnd = new Random();

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Math.Round(1.0 + rnd.NextDouble() * 98.99, 2);
        }

        Console.WriteLine("Масив:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + "\t");
            if ((i + 1) % 5 == 0)
                Console.WriteLine();
        }

        Console.Write("\nВведіть число для пошуку: ");
        double target = double.Parse(Console.ReadLine());

        int index1 = Array.IndexOf(arr, target);
        if (index1 >= 0)
            Console.WriteLine("Array.IndexOf: знайдено на індексі " + index1);
        else
            Console.WriteLine("Array.IndexOf: не знайдено");

        // Array.FindIndex - теж шукає індекс, але через умову
        int index2 = Array.FindIndex(arr, delegate (double x) { return x == target; });
        if (index2 >= 0)
            Console.WriteLine("Array.FindIndex: знайдено на індексі " + index2);
        else
            Console.WriteLine("Array.FindIndex: не знайдено");

        Console.WriteLine("\nЕлементи менші за " + target + ":");
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < target)
                Console.Write(arr[i] + "\t");
        }
        Console.WriteLine();

        double[] sorted = new double[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            sorted[i] = arr[i];
        }

        Array.Sort(sorted);

        Console.WriteLine("\nВідсортований масив:");
        for (int i = 0; i < sorted.Length; i++)
        {
            Console.Write(sorted[i] + "\t");
            if ((i + 1) % 5 == 0)
                Console.WriteLine();
        }

        int result = BinarySearch(sorted, target);

        Console.WriteLine("\nБінарний пошук:");
        if (result >= 0)
            Console.WriteLine("Знайдено! Індекс у відсортованому масиві: " + result);
        else
            Console.WriteLine("Елемент не знайдено");
    }
}
