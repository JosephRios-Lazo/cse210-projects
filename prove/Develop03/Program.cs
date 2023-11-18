using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create a sample library of scriptures
        var scriptureLibrary = new ScriptureLibrary();
        scriptureLibrary.AddScripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        scriptureLibrary.AddScripture("Proverbs 3:5-6", "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");

        // Run the memorization program with the library
        scriptureLibrary.RunMemorizer();
    }
}
