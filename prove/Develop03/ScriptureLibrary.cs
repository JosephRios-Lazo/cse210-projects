using System;
using System.Collections.Generic;
using System.Linq;

class ScriptureLibrary
{
    private List<Scripture> scriptures;

    public ScriptureLibrary()
    {
        scriptures = new List<Scripture>();
    }

    public void AddScripture(string referenceText, string scriptureText)
    {
        var scripture = new Scripture(referenceText, scriptureText);
        scriptures.Add(scripture);
    }

    public void RunMemorizer()
    {
        foreach (var scripture in scriptures)
        {
            Console.Clear();
            scripture.DisplayScripture();

            while (!scripture.AllWordsHidden())
            {
                Console.WriteLine("\nPress Enter to continue or type 'quit' to end:");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    return;

                scripture.HideRandomWords();
                Console.Clear();
                scripture.DisplayScripture();
            }
        }
    }
}