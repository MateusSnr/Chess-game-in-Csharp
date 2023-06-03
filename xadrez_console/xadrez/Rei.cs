using tabuleiro;
namespace xadrez
{
    class Rei : Peca
    {
        public Rei (Tabuleiro tab, Cor cor ) : base (tab, cor)
        {
            //Criando um objeto rei, utilizando a superclasse peca
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
