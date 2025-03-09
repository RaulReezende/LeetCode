namespace LeetCode._79;

class WordSearch
{
    public int indexWord = 0;
    public bool worked = false;
    public string word = "";

    public bool Exist(char[][] board, string wordh)
    {
        word = wordh;
        

        for (int l = 0; l < board.Length; l++)
        {
            for (int c = 0; c < board[0].Length; c++)
            {
                if (worked)
                    break;
                Procura(l, c, "", board);
            }
        }
        return worked;
    }
    public void Procura(int l, int c, string? posicaoAnterior, char[][] board)
    {
        if (worked)
            return;


        char[][] copyBoard = board.Select(x => x.ToArray()).ToArray();

        char singleWord = word[indexWord];
        char wordBoard = copyBoard[l][c];

        copyBoard[l][c] = ' ';

        if (singleWord == wordBoard)
        {
            if (indexWord == word.Length - 1)
            {
                worked = true;
                return;
            }

            indexWord++;

            int cima = l - 1;
            int direita = c + 1;
            int baixo = l + 1;
            int esquerda = c - 1;

            if (cima >= 0 && posicaoAnterior != "baixo")
            {
                Procura(cima, c, "cima", copyBoard);
            }
            if (direita <= board[0].Length - 1 && posicaoAnterior != "esquerda")
            {
                Procura(l, direita, "direita", copyBoard);
            }
            if (baixo <= board.Length - 1 && posicaoAnterior != "cima")
            {
                Procura(baixo, c, "baixo", copyBoard);
            }
            if (esquerda >= 0 && posicaoAnterior != "direita")
            {
                Procura(l, esquerda, "esquerda", copyBoard);
            }

            indexWord--;
        }

        return;
    }
}