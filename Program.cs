// See https://aka.ms/new-console-template for more information
using LeetCode._79;

char[][] board = [['A', 'B'], ['C', 'D']];
string word = "ACDB";

WordSearch ws = new();

Console.WriteLine(ws.Exist(board, word));
