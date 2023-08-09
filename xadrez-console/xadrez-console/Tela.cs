using tabuleiro;

namespace xadrez_console
{
    internal class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                Console.Write($"{8 - i} ");
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    Peca peca = tabuleiro.GetPeca(i, j);

                    if (peca != null)
                    {
                        Console.Write($"{peca} ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }

            Console.Write("  ");

            for (int i = 0; i < tabuleiro.Linhas; i++) {
                Console.Write($"{'a'} ");
            }
        }

    }
}
