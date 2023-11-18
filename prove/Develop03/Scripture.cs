using System;
using System.Collections.Generic;
using System.Linq;
class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(string referenceText, string scriptureText)
    {
        reference = new Reference(referenceText);
        words = scriptureText.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void DisplayScripture()
    {
        Console.WriteLine($"{reference.GetText()}\n");

        foreach (var word in words)
        {
            Console.Write(word.IsHidden ? "***** " : $"{word.Text} ");
        }

        Console.WriteLine();
    }

    public bool AllWordsHidden()
    {
        return words.All(word => word.IsHidden);
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int wordsToHide = random.Next(1, words.Count(word => !word.IsHidden) + 1);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(words.Count);
            words[index].IsHidden = true;
        }
    }
}