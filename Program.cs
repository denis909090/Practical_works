using System;
namespace project
{
     class Program
    {
        static void Main(string[] args)
        {   
            /* Task 2
            Console.WriteLine("Денис Гирман");
            Console.WriteLine("Введіть бажану к-ть хвилин. Ціле число");
            int minutes = int.Parse(Console.ReadLine() ?? "0");

            int hour = minutes / 60;
            int remaining_minutes = minutes % 60;
            Console.WriteLine($"{hour}год : {remaining_minutes}хв"); */

            /* Task 3
            Console.WriteLine("Введіть к-ть булочок");
            int n = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Введіть к-ть гривень");
            int x = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Введіть к-ть копійок");
            int y = int.Parse(Console.ReadLine()?? "0");
            int price_per_bun = (x * 100) + y;
            int total_amount = n * price_per_bun;
            int result_uah = total_amount / 100;
            int result_kop = total_amount % 100;
            Console.WriteLine($"За {n} булочок необхідно заплатити {result_uah} гривень {result_kop} копійок");

            */        
            //  Task 4
            Console.WriteLine("Гирман Денис");
            Console.WriteLine("Введіть к-ть комп. в першому класі");
            int C1 = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Введіть к-ть комп. в другому класі");
            int C2 = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine($"компʼютерів у 1 класі у вересні - {C1}. Компʼютерів у 2 класі у вересні - {C2}.");
            (C1,C2) = (C2, C1);
            Console.WriteLine($"компʼютерів у 1 класі у жовтні - {C1}. Компʼютерів у 2 класі у жовтні - {C2}.");
            C1 += 4;
            C2 -= 1;
            Console.WriteLine($"компʼютерів у 1 класі у грудні - {C1}. Компʼютерів у 2 класі у грудні - {C2 }.");
            
        }
    }
}