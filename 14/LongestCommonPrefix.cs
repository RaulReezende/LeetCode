using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._14;

public class LongestCommonPrefix
{
    public string Solution(string[] strs)
    {
        string res = "";
        for (int i = 0; i < strs[0].Length; i++)
        {
            foreach (string s in strs)
            {
                if (i == s.Length || s[i] != strs[0][i])
                {
                    return res;
                }
            }

            res += strs[0][i];
        }


        return res;
    }
}
