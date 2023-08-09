using tabuleiro.Exceptions;

namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] _pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            _pecas = new Peca[Linhas, Colunas];
        }

        public Peca GetPeca(int linha, int coluna)
        {
            return _pecas[linha, coluna];
        }

        public Peca GetPeca(Posicao posicao)
        {
            return _pecas[posicao.Linha, posicao.Coluna];
        }
        public void ColocarPeca(Peca peca, Posicao posicao)
        {
            if (ExistePeca(posicao)) throw new TabuleiroException("Já existe uma peça nessa posição");
            _pecas[posicao.Linha, posicao.Coluna] = peca;
            peca.Posicao = posicao;
        }

        public Peca RetirarPeca(Posicao posicao)
        {
            if (_pecas[posicao.Linha, posicao.Coluna] == null) return null;

            Peca auxPeca = _pecas[posicao.Linha, posicao.Coluna];
            auxPeca.Posicao = null;
            _pecas[posicao.Linha, posicao.Coluna] = null;

            return auxPeca;
        }

        public bool PosicaoValida(Posicao posicao)
        {
            if (posicao.Linha < 0 || posicao.Coluna < 0 || posicao.Linha >= Linhas || posicao.Coluna >= Colunas)
            {
                return false;
            }
            return true;
        }

        public bool ExistePeca(Posicao posicao)
        {
            ValidarPosicao(posicao);
            return _pecas[posicao.Linha, posicao.Coluna] != null;
        }

        public void ValidarPosicao(Posicao posicao)
        {
            if (!PosicaoValida(posicao)) throw new TabuleiroException("Posição Inválida");
        }
    }
}
