using System;

class Program
{
    static void Main(string[] args)
    {
        Address addressL = new Address("123 Elm Street", "Springfield", "IL", "USA");

        Lecture lecture = new Lecture("Exploring the Cosmos: A Journey into Outer Space", "Join us for an enlightening lecture on the mysteries of the universe", "March 15, 2024", "7 PM", addressL, "Dr. Celeste Astrum", 150);
        Console.WriteLine();

        Console.WriteLine("Event Number: 1");
        Console.WriteLine();
        Console.WriteLine(lecture.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateDetailedLecture());

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateShortLecture());

        Address addressR = new Address("567 Pine Street", "Seattle", "WA", "USA");

        Reception reception = new Reception("Harmony in Art: A Night of Elegance", "An evening of artistic celebration and cultural exchange.", "April 20, 2024", "8 PM", addressR, "harmonyartreception@gmail.com");
        Console.WriteLine();

        Console.WriteLine("Event Number: 2");
        Console.WriteLine();
        Console.WriteLine(reception.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(reception.GenerateDetailedReception());

        Console.WriteLine();
        Console.WriteLine(reception.GenerateShortReception());

        Address addressOG = new Address("890 Oak Avenue", "Alanta", "GA", "USA");

        OutdoorGathering outdoorGathering = new OutdoorGathering("Nature's Symphony: Sunset Serenade", "Immerse yourself in the beauty of nature with an outdoor gathering featuring live acoustic music, bonfires, and stargazing. ", "June 10, 2024", "7 PM", addressOG, "sunny`");
        Console.WriteLine();

        Console.WriteLine("Event Number: 3");

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateDetailedOutdoorGathering());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateShortOutdoorGathering());
    }
}