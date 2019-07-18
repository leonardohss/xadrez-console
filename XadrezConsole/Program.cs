using System;
using tabuleiro;
using xadrez;

namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 2);
            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());
            Console.ReadLine();
        }
    }
}
