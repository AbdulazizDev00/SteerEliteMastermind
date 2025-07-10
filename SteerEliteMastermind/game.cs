using System;

namespace MastermindGame
{
    class Game
    {
        private string SecretCode;
        private int MaxAttempts;

        public Game(string code, int attempts)
        {
            SecretCode = code;
            MaxAttempts = attempts;
        }

        public void Play()
        {
            int round = 0;
            while (round < MaxAttempts)
            {
                Console.WriteLine("---");
                Console.WriteLine($"Round {round}");
                Console.Write("> ");

                string input = Console.ReadLine();
                if (input == null) return; // Ctrl+D (EOF)

                if (!Validator.IsValidCode(input))
                {
                    Console.WriteLine("Wrong input!");
                    continue;
                }

                if (input == SecretCode)
                {
                    Console.WriteLine("Congratz! You did it!");
                    return;
                }

                var result = CodeChecker.Check(input, SecretCode);
                Console.WriteLine($"Well placed pieces: {result.WellPlaced}");
                Console.WriteLine($"Misplaced pieces: {result.Misplaced}");

                round++;
            }
        }
    }
}
