using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._17;

/*
    A primeira solução que eu fiz já é ótima ela funciona muito bem. Mas, tem como fazer melhor.
    Essa solução melhora bastante o tempo e o uso da memória. A ideia por trás é voltada para
    a variável phoneKeyboard, que no caso que fiz era um Dic com um array (Dictionary<string, List<string>>).
    Essa nova usa Dictionary<char, string>. Fica muito mais performático.
 
 */
public class LetterCombinationPhoneRefactor
{
    Dictionary<char, string> phoneKeyboard = new Dictionary<char, string>
    {
        {'2', "abc"},
        {'3', "def"},
        {'4', "ghi"},
        {'5', "jkl"},
        {'6', "mno"},
        {'7', "pqrs"},
        {'8', "tuv"},
        {'9', "wxyz"}
    };

    List<string> res = [];

    public IList<string> LetterCombinations(string digits)
    {
        if (digits == "") return [];
        Backtracking("", digits);
        return res;
    }

    private void Backtracking(string permutation, string nextDigits)
    {
        if (nextDigits.Length == 0)
        {
            res.Add(permutation);
            return;
        }

        foreach (char letter in phoneKeyboard[nextDigits[0]])
        {
            Backtracking(permutation + letter, nextDigits[1..]);
        }
    }
}
