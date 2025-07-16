using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._9;

public class Palindrome
{
    public bool IsPalindrome(int x)
    {
        // 121
        if (x < 0) return false;

        int copy = x;
        List<int> numbers = [];

        while (copy != 0)
        {
            numbers.Add(copy % 10);
            decimal de = copy / 10;
            copy = (int)Math.Floor(de);
        }

        int sum = 0; 

        foreach(var(index, n) in numbers.Index())
        {
            sum += n;
            if (index == numbers.Count - 1) break;
            sum *= 10;

        }
        return x == sum;
    }
}