using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] _pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            _pecas = new Peca[Linhas, Colunas];
        }

        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++ )
            {
                for ( int j = 0; j < tab.Colunas; j++)
                {
                    this._pecas(i, j) != null ? Console.WriteLine($"{_pecas(i, j)} ") : Console.WriteLine("_ ");
                }
            }
        }
    }
}
