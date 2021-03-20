using System;

namespace DeriGuess
{
    static class Program
    {
        private static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppInfo function to get info

            GreetUser(); // Ask for users name and greet

            while (true)
            {

                // Create a new Random object
                var random = new Random();

                // Init correct number
                var correctNumber = random.Next(1, 10);

                // Init guess var
                var guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get users input
                    var input = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        // Keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = int.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                // Print success message
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT!! You guessed it!");

                // Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                // Get answer
                var answer = Console.ReadLine().ToUpper();

                switch (answer)
                {
                    case "Y":
                        continue;
                    case "N":
                        return;
                    default:
                        return;
                }
            }

        }

        // Get and display app info
        private static void GetAppInfo()
        {
            // Set app vars
            var appName = "Number Guesser";
            var appVersion = "1.0.0";
            var appAuthor = "Derick Obi";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        // Ask users name and greet
        private static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            var inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        // Print color message
        private static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user its not a number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}
