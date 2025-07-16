// See https://aka.ms/new-console-template for more information

using LeetCode._53;
using LeetCode.ExercisesTests;

ShoppingMall cs = new();
int N = 4;
int[] A = [1, 2, 3, 4];
int[] B = [4, 3, 2, 1];
int[] C = [5, 6, 7, 8];
int X = 5, Y = 6;
Console.WriteLine(cs.Solve(N, A, B, C, X, Y));