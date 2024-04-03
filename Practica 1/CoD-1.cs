
using System;

class Program
{
    // Функция для вычисления суммы двух чиселaa
    return a + b;
    static void Main(string[] args)
    {
        GreetUser();
        string username = GetUserName();
        Console.WriteLine($"Привет, {username}!");
        DisplaySum();
    }
    static void GreetUser()
    {
        // Функция приветствия пользователя
        Console.WriteLine("Привет! Добро пожаловать в наше приложение.");
    }

    static string GetUserName()
    {
        // Функция для запроса имени пользователя
        Console.Write("Пожалуйста, введите ваше имя: ");
        string name = Console.ReadLine();
        return name;
    }

    static void DisplaySum()
    {
        // Функция для запроса двух чисел у пользователя и вывода их суммы
        Console.Write("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

    
        Console.Write("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = CalculateSum(num1, num2);
        Console.WriteLine($"Сумма введенных чисел: {result}");
    }

    static double CalculateSum(double a, double b)
    {
        // Функция для вычисления суммы двух чисел
        return a + b;
    }
}

