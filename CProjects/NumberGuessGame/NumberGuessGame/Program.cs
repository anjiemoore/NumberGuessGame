using System;
using System.Drawing;

namespace NumberGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {

            // Beginning of code
            //Asking user for name
            GreetUser();

            while (true)
            {
                //Creating random number
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                // Guess number
                int guessNumber = 0;

                //Asking user to guess number
                Console.WriteLine("Guess a number between 1 and 10");

                //While loop for user guessing
                while (guessNumber != correctNumber)
                {
                    //Getting user input
                    string inputGuess = Console.ReadLine();

                    //Checking userinput to make sure they enter a number
                    if (!int.TryParse(inputGuess, out guessNumber))
                    {
                        ColorMessage(ConsoleColor.Red, "Please enter a number");
                        continue;
                    }
                    //Parsing to integer and putting into the guessNumber variable
                    guessNumber = int.Parse(inputGuess);

                    //If else statement to run until they guess the correct number
                    if (guessNumber != correctNumber)
                    {
                        ColorMessage(ConsoleColor.Red, "Wrong answer, try again");

                    }
                    else
                    {
                        ColorMessage(ConsoleColor.Green, "Correct!");
                    }
                }

                //Ask user if they would like to play again
                Console.WriteLine("Would you like to play again? [Y or N]");

                //Getting user answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                } else if (answer == "N")
                {
                    Console.WriteLine("Thanks for playing!");
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        //Made a function to greet user and ask the name
        static void GreetUser()
        {
            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();
            Console.WriteLine("Hi {0}, let's play a game... ", inputName);
        }

        static void ColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
