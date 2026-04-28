using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your full name: ");
        string fullName = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());

        int result = age * favoriteNumber;

        Console.WriteLine($"Hello {fullName}!");
        Console.WriteLine($"You are {age} years old.");
        Console.WriteLine($"Your favorite number is {favoriteNumber}.");
        Console.WriteLine($"Age × Favorite Number = {result}");
    }
}