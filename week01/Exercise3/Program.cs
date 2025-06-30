using System;

class Program
{
    static void Main(string[] args)
    {
        //I'm using the random library here to get a random number and store it in a variable called randomNumber
        Random random = new Random();
        int randomNumber = random.Next(1, 100);
        int guessNumber = 0;
        int guessCount = 0;

        while (randomNumber != guessNumber)
        {
            Console.Write("What is your guess? ");
            string value = Console.ReadLine();
            guessNumber = int.Parse(value);
            guessCount++; // Increment guess count

            if (guessNumber > randomNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNumber == randomNumber)
            {
                Console.WriteLine($"Congratulation. You guessed it after {guessCount} guesses.");
            }
            else
            {
                Console.WriteLine("Higher");
            }
        }
        
    }
}