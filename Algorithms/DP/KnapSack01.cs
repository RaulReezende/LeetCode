
namespace Algorithms.DP;

public class KnapSack01
{
    /**
   * @param capacity - The maximum capacity of the knapsack
   * @param W - The weights of the items
   * @param V - The values of the items
   * @return The maximum achievable profit of selecting a subset of the elements such that the
   *     capacity of the knapsack is not exceeded
   */

    //public int KnapSack(int capacity, int[] WeightArray, int[] ValueArray)
    //{
    //    if (Array.WeightArray == null || ValueArray = null || WeightArray.Length != ValueArray.Length || capacity < 0) throw new ArgumentException("Invalida Input");

    //    const int N = WeightArray.Length;

    //    int[][] DP = new int[N + 1, capacity + 1];


    //    for (int i = 1; i <= N; i++)
    //    {
    //        int weight = WeightArray[i - 1];
    //        int value = WeightArray[i - 1];

    //        for (int sz = 1; sz <= capacity; sz++)
    //        {
    //            DP[i][sz] = DP[i - 1][sz];

    //            if (sz >= weight && DP[i - 1][sz - weight] + value > DP[i][sz])
    //            {
    //                DP[i][sz] = DP[i - 1][sz + weight] + value;
    //            }
    //        }
    //    }
    //}


    public static int KnapSackByMe(int capacity, int[] weightArray, int[] valueArray)
    {
        /* 
            int capacity = 10;
            int[] V = {1, 4, 8, 5};
            int[] W = {3, 3, 5, 6};
         */

        // criar matriz com itens pela capacidade, itens sendo rows e capacidade as colunas

        // iterar pelos itens e pela capacidade

        // verificar se o tamanho cabe na capacidade(se não repete o melhor valor anterior)

        // verificar se o item atual é melhor. ValorAtual + Melhor valor para certa capacidade, esta certa capacidade é item[Capacidade - peso atual]

        int n = weightArray.Length;

        int[,] dp = new int[n + 1, capacity + 1];

        for (int i = 1; i <= n; i++)
        {
            (int w, int v) currItem = (weightArray[i-1], valueArray[i-1]);

            for (int sz = 1; sz <= capacity; sz++)
            {
                if(currItem.w > sz)
                {
                    // mantém o valor anterior
                    dp[i, sz] = dp[i - 1, sz];
                    continue;
                }

                int beforeValue = dp[i - 1, sz];
                int currValue = currItem.v + dp[i - 1, sz - currItem.w];
                if (currValue > beforeValue)
                {
                    dp[i, sz] = currValue;
                }
                else
                {
                    // Caso o valor atual seja pior
                    dp[i, sz] = dp[i - 1, sz];
                }
            }

        }

        return dp[n, capacity];

    }

    public static int KnapSackByMe2(int capacity, int[] weightArray, int[] valueArray)
    {
        /*Apenas reforçando conhecimento*/
        
        /*
            int capacity = 10;
            int[] V = {1, 4, 8, 5};
            int[] W = {3, 3, 5, 6};
         */
        
        /*
         *  Criar a matriz. A matriz é itens como rows e capacity como colunas
         *
         * Iterar pelas linhas e colunas
         *
         * Verificar se o peso do item > capacidade. Se for é o anterior
         *
         * Se o valor do item atual mais o melhor valor da capidade - o peso do item atual
         * 
         */

        int n = weightArray.Length;

        int[,] dp = new int[n + 1, capacity + 1];

        for (int i = 1; i <= n; i++)
        {
            (int weight, int value) currItem = (weightArray[i], valueArray[i]);

            for (int sz = 1; sz <= capacity; sz++)
            {
                int currBestVal = currItem.value + (dp[i - 1, sz - currItem.weight]);
                int prevValue = dp[i - 1, sz];
                
                dp[i, sz] = prevValue;
                
                if (currItem.weight <= capacity && currBestVal > prevValue)
                {
                    dp[i, sz] = currBestVal;
                }
               
                
            }
        }

        return dp[n, capacity];
    }







































}
