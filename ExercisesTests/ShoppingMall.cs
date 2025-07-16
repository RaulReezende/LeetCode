using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ExercisesTests;

public class ShoppingMall
{
    public int Solve(int N, int[] Happiness, int[] Weight, int[] Cost, int MinHappy, int MaxWeight)
    {
        int currWeight = 0, currCost = 0, currHappiness = 0, bestCost = int.MaxValue;

        for (int i = 0; i < N; i++)
        {
            currWeight += Weight[i];
            currCost += Cost[i];
            currHappiness += Happiness[i];

            if(currWeight > MaxWeight)
            {
                currWeight = Weight[i];
                currCost = Cost[i];
                currHappiness = Happiness[i];
            }

            if (currHappiness >= MinHappy && currWeight <= MaxWeight)
            {
                bestCost = Math.Min(bestCost, currCost);
                currWeight = Weight[i];
                currCost = Cost[i];
                currHappiness = Happiness[i];
            }
        }

        return bestCost;
    }
}
