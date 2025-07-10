using System;
using System.Collections.Generic;

namespace MastermindGame
{
    static class CodeGenerator
    {
        public static string GenerateCode()
        {
            Random rand = new Random();
            HashSet<int> digits = new HashSet<int>();
            while (digits.Count < 4)
            {
                digits.Add(rand.Next(0, 9));
            }
            return string.Join("", digits);
        }
    }
}
