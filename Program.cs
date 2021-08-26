using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
            Let's Play a Guessing Game! Can you guess the secret number between 1 and 100?

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


            Console.WriteLine(@"
                Please choose a difficulty level:
                * Cheater (Unlimited Chances to Guess)
                * Easy (8 Chances to Guess)
                * Medium (6 Chances to Guess)
                * Hard (4 Chances to Guess)
            ");

            Console.Write("Choose your difficulty: "); // prompting user to choose difficulty level
            string difficultyLevel = Console.ReadLine().ToLower(); // storing user's choice of difficulty level

            Console.Write($"Enter your guess: ");
            string guess = Console.ReadLine(); // storing user's guess
            int parsedGuess = int.Parse(guess); // converting guess from a string to int
            Random randomNum = new Random(); // instantiating new Random number object from static method
            int secretNum = randomNum.Next(1, 100); // storing random number between 1 and 100 into secretNum variable
            int guessCount = 0; // initial guess count
            int guessLimit; // guess limit of 4 chances to guess secret number since initial count is 0
            bool outOfGuesses = false; // boolean indicating if user is out of guesses

            // Determines number of chances user has to guess number depending on difficulty level chosen:
            if (difficultyLevel == "easy")
            {
                guessLimit = 7;
            }
            else if (difficultyLevel == "medium")
            {
                guessLimit = 5;
            }
            else if (difficultyLevel == "hard")
            {
                guessLimit = 3;
            }
            else
            {
                guessLimit = int.MaxValue; // a property of the integer data type that represents the largest possible value of an int 
            }

            // while user's guess does not match secret number and user is not out of guesses, keep looping/asking user to guess
            while (parsedGuess != secretNum && !outOfGuesses)
            {
                if (guessCount < guessLimit) // if user has not reach guess limit, execute code below:
                {
                    if (parsedGuess > secretNum)
                    {
                        Console.WriteLine(@" 
                    
                            .-----.
                          .' -   - '.
                          /  .-. .-.  \
                          |  | | | |  |
                          \  \o/ \o/  /
                          _/    ^    \_
                          | \  '---'  / |
                          / /`--. .--`\ \         Whoopsie-daisy! Your guess was wrong!
                          / /'---` `---'\ \       Your guess was too high, guess lower! ;)
                          '.__.       .__.'       Try again bucko!
                              `|     |`
                              |     \
                              \      '--.
                                '.        `\
                                  `'---.   |
                                    ,__) /
                                      `..'

                        ");

                        int guessesLeft = guessLimit - guessCount; // variable will store number of guesses user has left and displays count:
                        Console.Write($"Enter your guess, you have {guessesLeft} guesses left: "); // prompt user to guess number again
                        parsedGuess = int.Parse(Console.ReadLine()); // converting string to int and storing user's guess to variable
                        guessCount++; // increment the guess count for each guess
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
                          / /`--. .--`\ \         Ooooh-lala! Incorrecto!
                          / /'---` `---'\ \       Your guess was too low! ;)
                          '.__.       .__.'       Try again buckeroo!
                              `|     |`
                              |     \
                              \      '--.
                                '.        `\
                                  `'---.   |
                                    ,__) /
                                      `..'

                        ");

                        int guessesLeft = guessLimit - guessCount; // variable will store number of guesses user has left and displays count:
                        Console.Write($"Enter your guess, you have {guessesLeft} guesses left: "); // prompt user to guess number again
                        parsedGuess = int.Parse(Console.ReadLine()); // converting string to int and storing user's guess to variable
                        guessCount++; // increment the guess count for each guess
                    }
                }
                else
                {
                    outOfGuesses = true;
                }
            }

            if (outOfGuesses)
            {
                Console.WriteLine(@"

                            .-----.
                          .' -   - '.
                          /  .-. .-.  \
                          |  | | | |  |
                          \  \o/ \o/  /
                          _/    ^    \_
                          | \  '---'  / |         You ran out of guesses!
                          / /`--. .--`\ \         Game over! Give me all your money!
                          / /'---` `---'\ \       Jk, but you did lose the game! :(
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
                          / /`--. .--`\ \         You just won 1 million dollars!
                          / /'---` `---'\ \       Sike, but you did just win the game!
                          '.__.       .__.'       Congrats, you're awesome! :D
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




















// using System;

// namespace GuessingGame
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine(@"
//             Shall we play a game? Guess the secret number!



//             ");
//           Console.WriteLine("--------------");




//             Console.Write("What is your guess?");
//             string guess = Console.ReadLine();
//             int parsedGuess = int.Parse(guess); // converting string to int
//             Random randomNum = new Random(); // instantiating new Random number object from static method
//             int secretNum = randomNum.Next(1, 100); // storing random number between 1 and 100 into secretNum variable
//             int guessCount = 0; // initial guess count
//             int guessLimit = 3; // guess limit of 4 chances to guess secret number since initial count is 0
//             bool outOfGuesses = false; // boolean indicating if user is out of guesses


//           // while user's guess does not match secret number and user is not out of guesses, keep looping/asking the user to guess
//           while(parsedGuess != secretNum && !outOfGuesses)
//           {
//             if (guessCount < guessLimit) // if user has not reached guess limit, execute code below:
//             {
//               if (parsedGuess > secretNum)
//               {
//                 Console.WriteLine(@"
                
                
                
                
//               .-----.
//             .' -   - '.
//             /  .-. .-.  \
//             |  | | | |  |
//             \  \o/ \o/  /           Your guess is incorrect!
//             _/    ^    \_           Your guess was too high.
//             | \  '---'  / |         Please try again!
//             / /`--. .--`\ \
//             / /'---` `---'\ \  
//             '.__.       .__.'
//                 `|     |`
//                  |     \
//                  \      '--.
//                   '.        `\
//                     `'---.   |
//                        ,__) /
//                         `..'

                
                
                
//                 ");

              
//               int guessesLeft = guessLimit - guessCount; // variable will store number of guesses user has left and displays count:
//               Console.Write($"Enter your guess, you have {guessesLeft} guesses left: "); // prompt user to guess number again
//               parsedGuess = int.Parse(Console.ReadLine()); // converting string to int and storing user's guess to variable
//               guessCount++; // increment the guess count for each guess
//               }
//             }
//             else 
//             {
//               outOfGuesses = true;
//             }
//           }


//             if (outOfGuesses)
//             {
//                 Console.WriteLine(@"
                


//               .-----.
//             .' -   - '.
//             /  .-. .-.  \
//             |  | | | |  |
//             \  \o/ \o/  /
//             _/    ^    \_
//             | \  '---'  / |
//             / /`--. .--`\ \
//             / /'---` `---'\ \   
//             '.__.       .__.'
//                 `|     |`
//                  |     \
//                  \      '--.
//                   '.        `\
//                     `'---.   |
//                        ,__) /
//                         `..'



//                 ");
//             }
//             else 
//             {
//                 Console.WriteLine(@"
                
                
                
//               .-----.
//             .' -   - '.
//             /  .-. .-.  \
//             |  | | | |  |
//             \  \o/ \o/  /
//             _/    ^    \_
//             | \  '---'  / |
//             / /`--. .--`\ \
//             / /'---` `---'\ \       Yay! You got it right!
//             '.__.       .__.'
//                 `|     |`
//                  |     \
//                  \      '--.
//                   '.        `\
//                     `'---.   |
//                        ,__) /
//                         `..'
                
//                 ");
//             }

//         }
//     }
// }
