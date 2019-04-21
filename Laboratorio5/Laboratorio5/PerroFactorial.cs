using System;
using System.Collections.Generic;
using System.Text;


namespace Laboratorio5
{
    public class PerroFactorial : ICalcular
    {


        public int Calcular(int number)
        {
            if (number > 13)
            {
                return number;
            }
            else
            {
                int resultado = 1;
                for (int i = 0; i <= number; i++)
                { resultado = resultado * i; }
                return resultado;
            }
        }
    }
}

