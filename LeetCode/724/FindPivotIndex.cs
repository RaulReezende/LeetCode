using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._724;

public class FindPivotIndex
{
    public int PivotIndex(List<int> nums)
    {
        long Total = nums.Sum();

        long Left = 0;

        foreach(var (index, number) in nums.Index())
        {
            if (Left == Total - Left - number) return index;

            Left += number;
        }

        return -1;
    }
}
