using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._1;

public class TwoSumRefactor
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dic.ContainsKey(nums[i]))
            {

                return [dic[nums[i]], i];
            }
            else
            {
                dic[target - nums[i]] = i;
            }
        }

        return [];
    }
}