using tabuleiro;
using tabuleiro.Enum;
using tabuleiro.Exceptions;
using Xadrez;
using Xadrez.Exceptions;
using Xadrez.TiposPecas;
using xadrez_console;

try
{
    Tabuleiro tab = new Tabuleiro(8, 8);

    //PosicaoXadrez px = new PosicaoXadrez(1, 'a');
    //Console.WriteLine(px);
    //Console.WriteLine(px.ToPosicao());

    tab.ColocarPeca(new Torre(Cor.Branco, tab), new Posicao(0, 0));
    tab.ColocarPeca(new Torre(Cor.Branco, tab), new Posicao(3, 4));
    tab.ColocarPeca(new Rei(Cor.Preto, tab), new Posicao(7, 7));

    Tela.ImprimirTabuleiro(tab);
}
catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}
catch (PosicaoXadrezException e)
{
    Console.WriteLine(e.Message);
}

