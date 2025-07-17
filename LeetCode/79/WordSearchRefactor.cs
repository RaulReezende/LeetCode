namespace LeetCode._79;
class WordSearchRefactor
{
    public bool exist(char[][] board, string word)
    {
        
        int n_rows = board.Length;
        int n_cols = board[0].Length;

        for(int row = 0; row < n_rows; row++)
        {
            for(int col = 0; col < n_cols; col++)
            {
                if (backtrack(board, n_rows, n_cols, row, col, word))
                    return true;
            }
        }
        return false;
    }
    
    bool backtrack(char[][] board, int n_rows, int n_cols, int row, int col, string suffix)
    {
        if (suffix.Length == 0)
            return true;

        if (row < 0 || row == n_rows 
            || col < 0 || col == n_cols
            || board[row][col] != suffix[0])
            return false;

        board[row][col] = ' ';

        (int, int)[] directions =
        [
            (0, 1),
            (1, 0), 
            (0, -1), 
            (-1, 0)
        ];

        foreach(var dir in directions)
        {
            bool res = backtrack(board, n_rows, n_cols, row+dir.Item1, col+dir.Item2, suffix[1..]);


            if (res)
                return true;

        }

            board[row][col] = suffix[0];

            return false;
    }
}

