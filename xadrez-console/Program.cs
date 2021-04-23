using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                Tela.imprimirTabuleiro(tab);

                //testando se existe peça no tabuleiro, chamando o método 'existePeca, na classe 'Tabuleiro.cs'
                Console.WriteLine(tab.existePeca(new Posicao(0, 0)));
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
  
        }
    }
}
