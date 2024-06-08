using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.com.florezsantiago.model.interfaces
{
    interface IFichas
    {
        Color_Valor color_valor { get; }
    }

    enum Color_Valor
    {
        Blanco = 1,
        Rojo = 5,
        Azul = 10,
        Verde = 25,
        Negro = 100,
        Morado = 500,
        Naranja = 1000
    }
}
