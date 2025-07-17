using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._9;

public class Palindrome2
{
    public bool IsPalindrome(int x)
    {
        // 121
        if (x < 0) return false;

        decimal copy = x;
        decimal sum = 0;

        while (copy != 0)
        {
            sum *= 10;
            sum += copy % 10;
            copy = (int)Math.Floor(copy / 10);
        }

        return x == sum ;
    }
}