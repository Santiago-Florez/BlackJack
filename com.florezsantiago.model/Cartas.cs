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
        public Color color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Palo palo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Valor valor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
