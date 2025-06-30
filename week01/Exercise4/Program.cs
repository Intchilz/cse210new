using System;
using System.Collections.Generic;
//using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        float userValue = 1;
        List<float> numbers = new List<float>();
        
        float sum = 0;
        float average = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (userValue >= 1)
        {
            Console.Write("Enter number: ");
            string value = Console.ReadLine();
            userValue = float.Parse(value);

            if (userValue > 0)
            {
                numbers.Add(userValue);
            }
            else if (userValue == 0)
            {
                int numbersCount = numbers.Count;
                foreach (int number in numbers)
                {
                    sum += number;
                    average = sum / numbersCount;
                }
                Console.WriteLine($"The sum is: {sum}");
                Console.WriteLine($"The average is: {average}");
                float max = numbers[0];

                foreach (float number in numbers)
                {
                    if (number > max)
                    {
                        max = number;
                    }
                }

                Console.WriteLine($"The largest number is: {max}");
            }
        }
        

    }
}