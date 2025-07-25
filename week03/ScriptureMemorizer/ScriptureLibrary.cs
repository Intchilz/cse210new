using System;
using System.Collections.Generic;

class ScriptureLibrary
{
    private List<Scripture> _scriptures;
    private Random _rand = new Random();

    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>();

        // Add scriptures here
        _scriptures.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all your heart and lean not on your own understanding; in all thy ways acknowledge him, and he shall direct thy paths."
        ));

        _scriptures.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."
        ));

        _scriptures.Add(new Scripture(
            new Reference("Psalm", 23, 1, 2),
            "The Lord is my shepherd; I shall not want. He maketh me to lie down in green pastures: he leadeth me beside the still waters."
        ));
    }

    public Scripture GetRandomScripture()
    {
        int index = _rand.Next(_scriptures.Count);
        return _scriptures[index];
    }
}
