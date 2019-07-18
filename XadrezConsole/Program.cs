using System;
using tabuleiro;
using xadrez;

namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                Tela.imprimirTabuleiro(tab);

                Console.ReadLine();

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Rei(tab, Cor.Verde), new Posicao(0, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(3, 4));

                Tela.imprimirTabuleiro(tab);
                
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
