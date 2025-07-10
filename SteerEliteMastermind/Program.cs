using System;

namespace MastermindGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string? secretCode = null;
            int attempts = 10;

            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "-c" && i + 1 < args.Length)
                    secretCode = args[i + 1];
                else if (args[i] == "-t" && i + 1 < args.Length && int.TryParse(args[i + 1], out int t))
                    attempts = t;
            }

            if (string.IsNullOrEmpty(secretCode))
                secretCode = CodeGenerator.GenerateCode();

            if (!Validator.IsValidCode(secretCode))
            {
                Console.WriteLine("Invalid secret code. It must be 4 distinct digits from 0 to 8.");
                return;
            }

            Console.WriteLine("Can you break the code? Enter a valid guess.");
            Game game = new Game(secretCode, attempts);
            game.Play();
        }
    }
}
