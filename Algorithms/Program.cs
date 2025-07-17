// See https://aka.ms/new-console-template for more information
using Algorithms.DP;

KnapSack01 cs = new();

const int capacity = 10;
int[] V = [1, 4, 8, 5];
int[] W = [3, 3, 5, 6];
Console.WriteLine(KnapSack01.KnapSackByMe(capacity, W, V));