using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
            Shall we play a game? Guess the secret number!


              .-----.
            .' -   - '.
            /  .-. .-.  \
            |  | | | |  |
            \  \o/ \o/  /
            _/    ^    \_
            | \  '---'  / |
            / /`--. .--`\ \
            / /'---` `---'\ \  
            '.__.       .__.'
                `|     |`
                 |     \
                 \      '--.
                  '.        `\
                    `'---.   |
                       ,__) /
                        `..'

            ");

            Console.Write("What is your guess?");
            string guess = Console.ReadLine();
            int parsedGuess = int.Parse(guess); // converting string to int
            Random randomNum = new Random(); // instantiating new Random number object from static method
            int secretNum = randomNum.Next(1, 100); // storing random number between 1 and 100 into secretNum variable
            int guessCount = 0; // initial guess count
            int guessLimit = 3; // guess limit of 4 chances to guess secret number since initial count is 0
            bool outOfGuesses = false; // boolean indicating if user is out of guesses


          // while user's guess does not match secret number and user is not out of guesses, keep looping/asking the user to guess
          while(parsedGuess != secretNum && !outOfGuesses)
          {
            if (guessCount < guessLimit) // if user has not reached guess limit, execute code below:
            {
              if (parsedGuess > secretNum)
              {
                Console.WriteLine(@"
                
                
                
                
              .-----.
            .' -   - '.
            /  .-. .-.  \
            |  | | | |  |
            \  \o/ \o/  /           Your guess is incorrect!
            _/    ^    \_           Your guess was too high.
            | \  '---'  / |         Please try again!
            / /`--. .--`\ \
            / /'---` `---'\ \  
            '.__.       .__.'
                `|     |`
                 |     \
                 \      '--.
                  '.        `\
                    `'---.   |
                       ,__) /
                        `..'

                
                
                
                ");

              
              int guessesLeft = guessLimit - guessCount; // variable will store number of guesses user has left and displays count:




              }
            }
          }



            if (parsedGuess == secretNum)
            {
                Console.WriteLine(@"
                


              .-----.
            .' -   - '.
            /  .-. .-.  \
            |  | | | |  |
            \  \o/ \o/  /
            _/    ^    \_
            | \  '---'  / |
            / /`--. .--`\ \
            / /'---` `---'\ \   Awesome job! You got it right!
            '.__.       .__.'
                `|     |`
                 |     \
                 \      '--.
                  '.        `\
                    `'---.   |
                       ,__) /
                        `..'



                ");
            }
            else 
            {
                Console.WriteLine(@"
                
                
                
              .-----.
            .' -   - '.
            /  .-. .-.  \
            |  | | | |  |
            \  \o/ \o/  /
            _/    ^    \_
            | \  '---'  / |
            / /`--. .--`\ \
            / /'---` `---'\ \       Uh-oh try again ... You got it wrong!
            '.__.       .__.'
                `|     |`
                 |     \
                 \      '--.
                  '.        `\
                    `'---.   |
                       ,__) /
                        `..'
                
                ");
            }

        }
    }
}
