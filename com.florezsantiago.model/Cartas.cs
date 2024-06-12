using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack.com.florezsantiago.model.interfaces;

namespace BlackJack.com.florezsantiago.model
{
    class Cartas : ICartas
    {
        public Color color { get; private set; }
        public Palo palo { get; private set; }
        public Valor valor { get; private set; }

        public Cartas(Color color, Palo palo, Valor valor)
        {
            this.color = color;
            this.palo = palo;
            this.valor = valor;
        }
    }
}
