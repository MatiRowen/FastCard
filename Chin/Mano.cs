using System;
namespace chin
{
    public class Mano
    {
        public const int TamMano = 24;
        private Carta[] cartas = new Carta[TamMano];
        private int contadorCartas = 0;
        public void AdCartaAMano(Carta repartirCarta)
        {
            if (this.contadorCartas >= TamMano)
            {
                throw new ArgumentException("Demasiadas Cartas");
            }
            this.cartas[this.contadorCartas] = repartirCarta; 
            this.contadorCartas++;
        }
        public override string ToString()
        {
            string resultado = "";
            foreach (Carta carta in this.cartas)
            {
                resultado += carta.ToString() + "\n";
            }
            return resultado;
        }
    }
}