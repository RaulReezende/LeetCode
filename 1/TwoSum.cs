namespace LeetCode._1;

public class TwoSumClass
{
    public int[] TwoSum(int[] nums, int target)
    {
        int [] numsCopy = [.. nums.Order()];
        int[] res = [];

        int pointerInit = 0;
        int pointerEnd = numsCopy.Length - 1;

        while(pointerInit != pointerEnd)
        {
            int sum = numsCopy[pointerInit] + numsCopy[pointerEnd];

            if (sum == target)
            {
                res = [numsCopy[pointerInit], numsCopy[pointerEnd]];
                break;
            }

            if (sum < target)
            {
                pointerInit++;
            }

            if (sum > target)
            {
                pointerEnd--;
            }
        }


        if (res[0] == res[1])
        {
            int first = Array.IndexOf(nums, res[0]);
            res = [Array.IndexOf(nums, res[0]), Array.IndexOf(nums, res[1], first + 1)];

        }
        else
        {
        res = [Array.IndexOf(nums, res[0]), Array.IndexOf(nums, res[1])];
        }
            return res;
    }
}

