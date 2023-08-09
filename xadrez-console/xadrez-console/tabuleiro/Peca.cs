using tabuleiro.Enum;

namespace tabuleiro
{
    internal abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public PecaTipo PecaTipo { get; protected set; }
        public Tabuleiro Tab { get; protected set; }
        public int QtdMovimentos { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            Posicao = null;
            Cor = cor;
            Tab = tab;
            QtdMovimentos = 0;
        }

        public override string ToString()
        {
            char PecaTipoChar = (char)PecaTipo;
            return $"{PecaTipoChar}";
        }

        public void AumentarQtdMovimentos() { QtdMovimentos++; }

        public abstract void Regras();
    }
}
