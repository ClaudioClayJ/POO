using Models;

namespace Oficina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pneu pneuMichelan = new Pneu(20, "Michelan");
            /*pneu.Exibir();
           pneu.Girar(15);*/

            Carro corcel = new Carro("Fiat", "Uno");

            corcel.LigarDesligar();
                corcel.Acelerar(100);
                corcel.Frear(20);
                //corcel.PneuTrazeiroEsquerdo = pneuMichelan;
                corcel.Exibir();

        }
        

    }
}