using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.com.florezsantiago.model.interfaces
{
    interface IJugador
    {
        string Name { get;}
        int Edad { get; set; }
        int apuesta { get; set; }
        int dineroTotal { get; set; }
        bool apostar();
        bool retirarse();
    }
}
