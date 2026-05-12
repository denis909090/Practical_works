using System;

class IndivTask2
{
    public static string GeneratePassword(int length)
    {
        string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        Random rnd = new Random();
        string password = "";
        for (int i = 0; i < length; i++)
        {
            int index = rnd.Next(0, chars.Length);
            password = password + chars[index];
        }
        return password;
    }

    public static void Run()
    {
        Console.Write("Введіть довжину паролю: ");
        int length = int.Parse(Console.ReadLine());
        string password = GeneratePassword(length);
        Console.WriteLine("Згенерований пароль: " + password);
    }
}
