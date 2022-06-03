using System;
namespace chin
{
    public class Pack
    {
        public const int NumPalos = 4;
        public const int CartasPorPalo = 12 ;
        private Carta[,] packCarta;
        private Random selectorCartaRandom = new Random();
        public Pack()
        {
            this.packCarta = new Carta[NumPalos, CartasPorPalo];
            for (Palo palo = Palo.Oros; palo <= Palo.Bastos; palo++)
            {
                for (Valor valor = Valor.Uno; valor <= Valor.Doce; valor++)
                {
                    this.packCarta[(int)palo, (int)valor] = new Carta(palo, valor);
                }
            }
        }
        public Carta RepartirCartaDePack()
        {
            Palo palo = (Palo)selectorCartaRandom.Next(NumPalos);
            while (this.EstaPaloVacio(palo))
            {
                palo = (Palo)selectorCartaRandom.Next(NumPalos);
            }
            Valor valor = (Valor)selectorCartaRandom.Next(CartasPorPalo);
            while (this.CartaYaRepartida(palo, valor))
            {
                valor = (Valor)selectorCartaRandom.Next(CartasPorPalo);
            }
            Carta carta = this.packCarta[(int)palo, (int)valor];

            this.packCarta[(int)palo, (int)valor] = null;
            return carta;
        }
        private bool EstaPaloVacio(Palo palo)
        {
            bool resultado = true;
            for (Valor valor = Valor.Uno; valor <= Valor.Doce; valor++)
            {
                if (!CartaYaRepartida(palo, valor))
                {
                    resultado = false;
                    break;
                }
            }
            return resultado;
        }

        private bool CartaYaRepartida(Palo palo, Valor valor)
        {
            return (this.packCarta[(int)palo, (int)valor] == null);
        }
    }
}
