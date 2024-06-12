using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack.com.florezsantiago.model;
using BlackJack.com.florezsantiago.model.interfaces;

namespace BlackJack.com.florezsantiago.main
{
    class Controller
    {

        private List<Cartas> cartas = new List<Cartas>();

        public Controller()
        {
            Funcionar();
        }

        public void Funcionar()
        {
            
        }

        private void crearCartas(Cartas cart)
        {
            cartas.Add(cart);            
        }
    }
}
