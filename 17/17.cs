using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._17;

internal class LetterCombinationPhone
{
    Dictionary<string, List<string>> phoneKeyboard = new Dictionary<string, List<string>>
    {
        {"2", ["a", "b", "c"]},
        {"3", ["d", "e", "f"]},
        {"4", ["g", "h", "i"]},
        {"5", ["j", "k", "l"]},
        {"6", ["m", "n", "o"]},
        {"7", ["p", "q", "r", "s"]},
        {"8", ["t", "u", "v"]},
        {"9", ["w", "x", "y", "z"]}
    };

    List<string> res = [];
    public List<string> Solution(string digits)
    {
        if (digits == "") return [];
        Backtracking("", digits);
        return res;
    }

    private void Backtracking(string permutation, string digits)
    {
        if (digits.Length == 0)
        {
            res.Add(permutation);
            return;
        }

        foreach (string letter in phoneKeyboard[digits[0].ToString()])
        {
            Backtracking(permutation+letter, digits[1..]);
        }
    }
}
