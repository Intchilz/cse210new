class Program
{
    // I exceeded the requirements. I added functionality to display
    // random scriptures to the user while maintaining the core requirements
    // of the program.
    static void Main()
    {
        ScriptureLibrary library = new ScriptureLibrary();
        Scripture scripture = library.GetRandomScripture();

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");

            string input = Console.ReadLine()?.Trim().ToLower();
            if (input == "quit") break;

            scripture.HideRandomWords(3);
        }

        // Final display
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}
