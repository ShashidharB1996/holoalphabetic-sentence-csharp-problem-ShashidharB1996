using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        // Write the logic to determine whether the input string is a HoloalphabeticSentence or not
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
            string charStr = String.Concat(input.ToLower().ToCharArray().Distinct().OrderBy(c => c));
            if (charStr.Contains(alphabets))
                return true;

            return false;
        }
    }
}
