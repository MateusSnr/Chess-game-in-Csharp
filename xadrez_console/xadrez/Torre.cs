using tabuleiro;

namespace xadrez
{
    class Torre:Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
            //Criando um objeto rei, utilizando a superclasse peca
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
