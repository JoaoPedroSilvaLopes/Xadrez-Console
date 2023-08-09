using tabuleiro;
using tabuleiro.Enum;

namespace Xadrez.TiposPecas
{
    internal class Peao : Peca
    {
        public Peao(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
            PecaTipo = PecaTipo.Peao;
        }

        public override void Regras()
        {
            throw new NotImplementedException();
        }
    }
}
