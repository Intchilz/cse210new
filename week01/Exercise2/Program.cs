using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        string value = Console.ReadLine();
        int grade = int.Parse(value);

        string letter = "";
        string sign = "";

        if (grade > 100)
        {
            Console.WriteLine("Your grade can only be between 1 and 100.");
        }
        else if (grade >= 93)
        {
            letter = "A";
            Console.Write($"Your grade is {letter}. ");
            Console.WriteLine("Congratulations, you passed.");
        }
        else if (grade >= 90 && grade < 93)
        {
            letter = "A";
            sign = "-";
            Console.Write($"Your grade is {letter}{sign}. ");
            Console.WriteLine("Congratulations, you passed.");
        }
        else if (grade >= 87 && grade <= 89)
        {
            letter = "B";
            sign = "+";
            Console.Write($"Your grade is {letter}{sign}. ");
            Console.WriteLine("Congratulations, you passed.");
        }
        else if (grade >= 83 && grade <= 86)
        {
            letter = "B";
            Console.Write($"Your grade is {letter}. ");
            Console.WriteLine("Congratulations, you passed.");
        }
        else if (grade >= 80 && grade <= 82)
        {
            letter = "B";
            sign = "-";
            Console.Write($"Your grade is {letter}{sign}. ");
            Console.WriteLine("Congratulations, you passed.");
        }
        else if (grade >= 77 && grade <= 79)
        {
            letter = "C";
            sign = "+";
            Console.Write($"Your grade is {letter}{sign}. ");
            Console.WriteLine("Congratulations, you passed.");
        }
        else if (grade >= 73 && grade <= 76)
        {
            letter = "C";
            Console.Write($"Your grade is {letter}{sign}. ");
            Console.WriteLine("Congratulations, you passed.");
        }
        else if (grade >= 70 && grade <= 72)
        {
            letter = "C";
            sign = "-";
            Console.Write($"Your grade is {letter}{sign}. ");
            Console.WriteLine("Congratulations, you passed.");
        }
        else if (grade >= 67 && grade <= 69)
        {
            letter = "D";
            sign = "+";
            Console.Write($"Your grade is {letter}{sign}. ");
            Console.WriteLine("Better luck next time.");
        }
        else if (grade >= 63 && grade <= 66)
        {
            letter = "D";
            Console.Write($"Your grade is {letter}. ");
            Console.WriteLine("Better luck next time.");
        }
        else if (grade >= 60 && grade <= 62)
        {
            letter = "D";
            sign = "-";
            Console.Write($"Your grade is {letter}{sign}. ");
            Console.WriteLine("Better luck next time.");
        }
        else
        {
            letter = "F";
            Console.Write($"Your grade is {letter}. ");
            Console.WriteLine("You need to work hard.");
        }


    }

}