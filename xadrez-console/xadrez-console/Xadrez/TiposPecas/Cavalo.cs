using tabuleiro;
using tabuleiro.Enum;

namespace Xadrez.TiposPecas
{
    internal class Cavalo : Peca
    {
        public Cavalo(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
            PecaTipo = PecaTipo.Cavalo;
        }

        public override void Regras()
        {
            throw new NotImplementedException();
        }
    }
}
