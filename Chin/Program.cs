using System;

namespace chin
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NumManos=2;
            Mano[]manos={new Mano(),new Mano()};
            Pack pack = new Pack();
            for(int numMano = 0; numMano<NumManos; numMano++){
                for(int numCartas = 0; numCartas<Mano.TamMano; numCartas++){
                    Carta repartirCarta = pack.RepartirCartaDePack();
                    manos[numMano].AdCartaAMano(repartirCarta);
                }
                Console.WriteLine("Mano de jugador " + (numMano+1) + ":");
                Console.WriteLine( manos[numMano]);
            }
        }
    }
}
