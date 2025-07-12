using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._79;

public class WordSearch2
{
    public bool Solution(char[][] board, string word)
    {
        for (int row = 0; row < board.Length; row++) 
        {
            for (int col = 0; col < board[0].Length; col++) 
            {
                if (Backtracking(board, row, col, word))
                {
                    return true;
                }
                
            }
        }

        return false;
    }

    internal bool Backtracking(char[][] board, int row, int col, string word)
    {
        if (word.Length == 0) return true;

        if (
                row == board.Length ||
                row < 0  ||
                col < 0 ||
                col == board[0].Length ||
                board[row][col] != word[0]
            )
        {
            return false;
        }

        board[row][col] = '#';

        List<(int dx, int dy)> positions = [(0, 1), (1, 0), (-1, 0), (0, -1)];

        foreach((int dx, int dy) in positions)
        {
            if(Backtracking(board, row+dx, col+dy, word[1..])) return true;
        }

        board[col][row] = word[0];


        return false;
    }
}
