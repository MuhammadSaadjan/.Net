using System;

class GuessingGame
{
    static void Main() {
        int coded_num = 15;
        int Guess = 0;
        int attempts = 0; 
        Console.Write("Guess the number: ");

        while (Guess != coded_num) {
            
            bool isValid = int.TryParse(Console.ReadLine(), out Guess);
            if (!isValid)
            {
                
                    Console.Write("Invalid input. Please enter a number: ");
                    continue;
                
            }
            attempts++;
            if (Guess < coded_num) {
                Console.Write("Too Low, Try again.");
            }
            if (Guess > coded_num) {
                Console.Write("Too High, Try Again.");
            }
        }

        
            Console.WriteLine("Congratulations! You Found the Secret number");
        Console.Write($"You found the number in {attempts} attempts");
       

    }
}