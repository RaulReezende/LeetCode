using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._1;

public class TwoSumRefactor2
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dic = new();

        foreach(var (index, value) in nums.Index())
        {
            if (dic.TryGetValue(value, out int dicValue))
            {
                return [dicValue, index]; 
            } else
            {
                dic[target - value] = index;
            }
        }

        return [];
    }
}
