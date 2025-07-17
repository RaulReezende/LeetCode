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
                Procura(l, c, Posicao.vazio, board);
            }
        }
        return worked;
    }
    public void Procura(int l, int c, Posicao posicaoAnterior, char[][] board)
    {
        if (worked)
            return;


        char singleWord = word[indexWord];
        char wordBoard = board[l][c];


        if (singleWord == wordBoard)
        {
            if (indexWord == word.Length - 1)
            {
                worked = true;
                return;
            }
        
            
            board[l][c] = ' ';
            indexWord++;

            int cima = l - 1;
            int direita = c + 1;
            int baixo = l + 1;
            int esquerda = c - 1;

            if (cima >= 0 && posicaoAnterior != Posicao.baixo)
            {
                Procura(cima, c, Posicao.cima, board);
            }
            if (direita <= board[0].Length - 1 && posicaoAnterior != Posicao.esquerda)
            {
                Procura(l, direita, Posicao.direita, board);
            }
            if (baixo <= board.Length - 1 && posicaoAnterior != Posicao.cima)
            {
                Procura(baixo, c, Posicao.baixo, board);
            }
            if (esquerda >= 0 && posicaoAnterior != Posicao.direita)
            {
                Procura(l, esquerda, Posicao.esquerda, board);
            }

            indexWord--;
            board[l][c] = word[indexWord];
        }

        return;
    }
}

enum Posicao
{
    vazio,
    baixo,
    esquerda,
    cima,
    direita
}