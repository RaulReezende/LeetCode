using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._53;

public class MaxSubArray
{
    // nums = [-2,1,-3,4,-1,2,1,-5,4]
    public int MaxSubArrayKadane(int[] nums)
    {
        int currSum = 0;
        int maxSum = int.MinValue;

        foreach(int n in nums)
        {
            currSum = Math.Max(n, currSum + n);
            maxSum = Math.Max(currSum, maxSum);
        }

        return maxSum;
    }

    public int MaxSubArrayDC(int[] nums)
    {
        return HelperMaxSub(nums, 0, nums.Length - 1);
    }

    private int HelperMaxSub(int[] numbers, int L, int R)
    {
        if (L > R) return int.MinValue;

        int mid = (L + R) / 2;

        int currSum = 0;
        int leftSum = 0;

        for (int i = mid - 1; i >= 0; i--)
        {
            currSum += numbers[i];
            leftSum = Math.Max(leftSum, currSum);
        }

        currSum = 0;
        int rightSum = 0;
        for (int i = mid + 1; i <= R; i++)
        {
            currSum += numbers[i];
            rightSum = Math.Max(rightSum, currSum);
        }

        return Math.Max(Math.Max(HelperMaxSub(numbers, L, mid - 1), HelperMaxSub(numbers, mid + 1, R)), leftSum + numbers[mid] + rightSum);

    }
}
