using tabuleiro;
using tabuleiro.Enum;

namespace Xadrez.TiposPecas
{
    internal class Torre : Peca
    {
        public Torre(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
            PecaTipo = PecaTipo.Torre;
        }

        public override void Regras()
        {
            throw new NotImplementedException();
        }
    }
}
