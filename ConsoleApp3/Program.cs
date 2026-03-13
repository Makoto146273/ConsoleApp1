using System;

class Program
{
    static void Main()
    {
        // Ввод двух чисел
        Console.Write("Введите первое число: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double b = Convert.ToDouble(Console.ReadLine());

        // Арифметические операции
        double sum = a + b;
        double difference = a - b;
        double product = a * b;
        double quotient = a / b;

    }
}
