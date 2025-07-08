using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        PromptGenerator randomprompt = new PromptGenerator();
        randomprompt._randomPrompt = "";


        Events event1 = new Events();
        event1._option = "Welcome to the Journal program!";
        event1._option7 = "Please select one of the following choices";
        event1._option1 = "1. Write ";
        event1._option2 = "2. Display ";
        event1._option3 = "3. Load";
        event1._option4 = "4. Save";
        event1._option5 = "5. Quit";
        event1._option6 = "What would you like to do? ";
        event1._response = "";
        event1._event = "";
        event1._date = DateTime.Now;

        Journal journal1 = new Journal();
        journal1._fileName = "original.txt";
        journal1._FileContent = "";
        journal1._date = event1._date.ToShortDateString();

        event1.Display();
        Console.Write(event1._option6);
        event1._response = Console.ReadLine();
        option = int.Parse(event1._response);

        if (option == 1)
        {
            randomprompt.RandomQuestion();
            journal1._question = randomprompt._randomPrompt;

            Console.WriteLine(randomprompt._randomPrompt);
            event1._event = Console.ReadLine();
            journal1._FileContent = event1._event;

            journal1.SaveToFile();
        }
        else if (option == 3)
        {
            Console.WriteLine("What is the filename: ");
            journal1._fileName = Console.ReadLine();

            journal1.LoadFromFile();
        }
        else if (option == 5)
        {
            Environment.Exit(0);
        }

        while (option != 5)
            {
                event1.Display();
                Console.Write(event1._option6);
                event1._response = Console.ReadLine();
                option = int.Parse(event1._response);

                if (option == 1)
                {
                    randomprompt.RandomQuestion();
                    journal1._question = randomprompt._randomPrompt;
                    Console.WriteLine(randomprompt._randomPrompt);
                    event1._event = Console.ReadLine();
                    Console.WriteLine("");
                    journal1._FileContent = event1._event;

                    journal1.AppendToFile();
                }
                else if (option == 2)
                {
                    journal1.Read();
                }
                else if (option == 3)
                {
                    Console.WriteLine("What is the filename: ");
                    journal1._fileName = Console.ReadLine();

                    journal1.LoadFromFile();
                }
                else if (option == 4)
                {
                    Console.WriteLine("What is the filename: ");
                    journal1._fileName = Console.ReadLine();

                    journal1.createNewFile();
                }

                else
                {
                    Environment.Exit(0);
                }
            }
    }
}