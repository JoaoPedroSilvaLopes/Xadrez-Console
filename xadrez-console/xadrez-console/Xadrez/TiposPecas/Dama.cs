using tabuleiro;
using tabuleiro.Enum;

namespace Xadrez.TiposPecas
{
    internal class Dama : Peca
    {
        public Dama(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
            PecaTipo = PecaTipo.Dama;
        }

        public override void Regras()
        {
            throw new NotImplementedException();
        }
    }
}
