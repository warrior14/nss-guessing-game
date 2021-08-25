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
            int parsedGuess = int.Parse(guess);
            int secretNum = 21;

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
