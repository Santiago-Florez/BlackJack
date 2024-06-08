using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.com.florezsantiago.model.interfaces
{
    interface  ICartas
    {
        Color color { get; set; }
        Palo palo { get; set; }
        Valor valor { get; set; }
    }

    enum Color
    {
        Rojo,
        Negro
    }

    enum Palo
    {
        Trevol,
        Corazon,
        Pica,
        Dianante
    }

    enum Valor
    {
        A = 1,
        Dos = 2,
        Tres = 3,
        Cuatro = 4,
        Cinco = 5,
        Seis = 6,
        Siete = 7,
        Ocho = 8,
        Nueve = 9,
        Diez = 10,
        J = 10,
        Q = 10,
        K = 10
    }
}
