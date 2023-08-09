using tabuleiro;
using tabuleiro.Enum;

namespace Xadrez.TiposPecas
{
    internal class Rei : Peca
    {
        public Rei(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
            PecaTipo = PecaTipo.Rei;
        }

        public override void Regras()
        {
            throw new NotImplementedException();
        }
    }
}
