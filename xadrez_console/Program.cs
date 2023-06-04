using System;
using tabuleiro;
using xadrez;

namespace xadrez_console 
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Posicao p;

            p = new Posicao(3, 4);

            Console.WriteLine(p);
            

            Tabuleiro tab = new Tabuleiro(8,8);

            tab.colocarPeca(new Torre(tab, Cor.Preta),new Posicao(0,0));
            tab.colocarPeca(new Torre(tab, Cor.Preta),new Posicao(1,3));
            tab.colocarPeca(new Rei(tab, Cor.Preta),new Posicao(2,4));

            Tela.imprimirTabuleiro(tab);
            

            PosicaoXadrez pos = new PosicaoXadrez('a', 1);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();

            */
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab);
                        Console.WriteLine();
                        Console.WriteLine("Turno: " + partida.turno);
                        Console.Write("Aguardando jogada:  " + partida.jogadorAtual);

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);
                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeDestino(origem, destino);

                        partida.realizaJogada(origem, destino);

                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine( e.Message);
                        Console.ReadLine();
                    }

                }
            }
            catch (TabuleiroException e )
            {
                Console.WriteLine( e.Message);
            }

            Console.ReadLine();

        }
    }
}

