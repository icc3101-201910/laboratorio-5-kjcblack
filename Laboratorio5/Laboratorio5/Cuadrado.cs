using System;
using System.Collections.Generic;
using System.Text;


namespace Laboratorio5
{
    public class Cuadrado : ICalcular
    {

        public int Calcular(int number)
        {
            return number * number;
        }
    }
}