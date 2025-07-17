using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._13;

public class RomanInteger
{
    Dictionary<char, int> romanMap = new()
    {
        {'I', 1 },
        {'V', 5 },
        {'X', 10 },
        {'L', 50 },
        {'C', 100 },
        {'D', 500 },
        {'M', 1000 },
    };

    public int RomanToInt(string s)
    {
        int sum = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (i != s.Length - 1 && romanMap.GetValueOrDefault(s[i]) < romanMap.GetValueOrDefault(s[i + 1]))
            {
                sum += romanMap.GetValueOrDefault(s[i + 1]) - romanMap.GetValueOrDefault(s[i]);
                i++;
            }
            else
            {
                sum += romanMap.GetValueOrDefault(s[i]);
            }
        }

        return sum;
    }
}
