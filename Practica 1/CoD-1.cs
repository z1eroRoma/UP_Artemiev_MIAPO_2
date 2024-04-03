static void GreetUser()
{
    // Функция приветствия пользователя
    Console.WriteLine("Привет! Добро пожаловать в наше приложение.");
}

static string GetUserName()
{
    // Функция для запроса имени пользователя
    Console.Write("Пожалуйста, введите ваше имя2: ");
    string name = Console.ReadLine();
    return name;
}