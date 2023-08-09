using tabuleiro;
using Xadrez.Exceptions;

namespace Xadrez
{
    internal class PosicaoXadrez
    {
        public int Linha { get; set; }
        public char Coluna { get; set; }

        public PosicaoXadrez(int linha, char coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

        public Posicao ToPosicao()
        {
            if (Coluna < 'a' || Coluna > 'h' || Linha < 1 || Linha > 8) throw new PosicaoXadrezException("Posição de xadrez inválida");
            return new Posicao(8 - Linha, Coluna - 'a');
        }

        public override string ToString()
        {
            return $"{Coluna.ToString().ToUpper()}{Linha}";
        }
    }
}
