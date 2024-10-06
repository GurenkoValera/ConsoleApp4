using System;

class Program
{
    static void Main()
    {
        // Инициализация переменных
        int a = 5;
        int b = 10;

        Console.WriteLine("До обмена : a = {0}, b = {1}", a, b);

        // Обмен значениями без использования дополнительных переменных
        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("После обмена : a = {0}, b = {1}", a, b);
    }
}
