using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ExamplesTests;

public class DivideConquer
{
    public int ReturnMaxInt(int[] nums)
    {
        return Backtr(nums);
    }

    private int Backtr(int[] numbers)
    {
        if (numbers.Length == 1) return numbers[0];

        //calc pivot
        int pivot = (int)Math.Floor(numbers.Length/ 2.0);


        //left right
        int left = Backtr(numbers[0..pivot]);
        //pivot += 1;
        int right = Backtr(numbers[pivot..numbers.Length]);

        return Math.Max(left, right);
    }
}
