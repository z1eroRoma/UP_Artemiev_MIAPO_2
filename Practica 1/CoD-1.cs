using System;

class Program
{
    static void Main(string[] args)
    {
        GreetUser();
        string username = GetUserName();
        Console.WriteLine($"Привет, {username}!");
        DisplaySum();
    }