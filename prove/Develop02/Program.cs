using System;

class Program
    {
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today? ",
            "What was the best part of my day? ",
            "How did I see the hand of the Lord in my life today? ",
            "What was the strongest emotion I felt today? ",
            "If I had one thing I could do over today, what would it be? ",
            "What meal was the best today? ",
            "Where did I go today? ",
            "What did I eat today? ",
            "What would I like to do tomorrow? ",
            "What was the worst part of the day? ",
            "How can I make the next day better than today? "

        };

        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("Please Select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.Write("\nWhat would you like to do? ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = GetRandomPrompt(prompts);
                    journal.AddEntry(prompt);
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    journal.SaveToFile();
                    break;
                case "4":
                    journal.LoadFromFile();
                    break;
                case "5":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
        Console.WriteLine("See you tomorrow!");
    }

    static string GetRandomPrompt(List<string> prompts)
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
    }