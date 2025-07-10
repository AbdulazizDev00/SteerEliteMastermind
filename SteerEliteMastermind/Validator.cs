using System.Linq;

namespace MastermindGame
{
    static class Validator
    {
        public static bool IsValidCode(string code)
        {
            return code.Length == 4 &&
                   code.All(char.IsDigit) &&
                   code.All(c => c >= '0' && c <= '8') &&
                   code.Distinct().Count() == 4;
        }
    }
}
