using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        

        int square = SquareNumber(userNumber);

        DisplayResult(userName, square);

        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());

            return userNumber;
        }

        static int SquareNumber(int userNumber)
        {
        int square = userNumber * userNumber;
        return square;
        }

        static void DisplayResult(string userName, int square)
        {
            Console.WriteLine($"{userName}, the square of your number is {square}");
        }

    }
}