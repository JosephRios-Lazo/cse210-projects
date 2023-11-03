using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percentGrade = int.Parse(userInput);

        string letterGrade = "";

        if (percentGrade >= 90) 
        {
            letterGrade = "A";
        }
        else if (percentGrade >=80)
        {
            letterGrade = "B";
        }
        else if (percentGrade >= 70)
        {
            letterGrade = "C";
        }
        else if (percentGrade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your letter grade is {letterGrade}.");

        if (percentGrade >= 70)
        {
            Console.WriteLine("You passed the class! Congrats!");
        }
        else
        {
            Console.WriteLine("You can do it next time!");
        }
    }
}