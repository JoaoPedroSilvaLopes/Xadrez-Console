using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_console
{
    internal class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < Linhas; i++)
            {
                for (int j = 0; j < Colunas; j++)
                {
                    this._pecas(i, j) != null ? Console.WriteLine($"{_pecas(i, j)} ") : Console.WriteLine("_ ");
                }
            }
        }
    }
}
