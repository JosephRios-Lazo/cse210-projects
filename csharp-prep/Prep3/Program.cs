using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        string keepPlaying = "yes";

        while (keepPlaying == "yes")
        {
            int count = 0;
            int magicNumber = randomGenerator.Next(1, 101);
            int guessNumber = -1;

            do
            {
                Console.Write("What is your guess? ");
                string userInput = Console.ReadLine();
                guessNumber = int.Parse(userInput);

                if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }

                count = count + 1;
            } while (guessNumber != magicNumber);

            Console.WriteLine($"You guessed {count} times."); 
            Console.Write("Do you want to keep playing? ");  
            keepPlaying = Console.ReadLine();   
        }

            
    } 
}