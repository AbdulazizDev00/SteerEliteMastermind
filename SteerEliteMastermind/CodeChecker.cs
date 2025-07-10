using System;
using System.Collections.Generic;

namespace MastermindGame
{
    static class CodeChecker
    {
        public static Result Check(string guess, string code)
        {
            int wellPlaced = 0;
            int misplaced = 0;

            Dictionary<char, int> codeCount = new Dictionary<char, int>();
            Dictionary<char, int> guessCount = new Dictionary<char, int>();

            for (int i = 0; i < 4; i++)
            {
                if (guess[i] == code[i])
                {
                    wellPlaced++;
                }
                else
                {
                    if (!codeCount.ContainsKey(code[i])) codeCount[code[i]] = 0;
                    codeCount[code[i]]++;

                    if (!guessCount.ContainsKey(guess[i])) guessCount[guess[i]] = 0;
                    guessCount[guess[i]]++;
                }
            }

            foreach (var g in guessCount)
            {
                if (codeCount.ContainsKey(g.Key))
                {
                    misplaced += Math.Min(g.Value, codeCount[g.Key]);
                }
            }

            return new Result { WellPlaced = wellPlaced, Misplaced = misplaced };
        }
    }

    class Result
    {
        public int WellPlaced { get; set; }
        public int Misplaced { get; set; }
    }
}
