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