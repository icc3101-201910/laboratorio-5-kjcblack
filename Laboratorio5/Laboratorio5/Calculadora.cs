using System;
using System.Collections.Generic;
using System.Text;



namespace Laboratorio5
{
    class Calculadora
    {

        private int numero;
        public List<ICalcular> calculadoras;

        public Calculadora(int numeroInicial)
        {
            numero = numeroInicial;
            calculadoras = new List<ICalcular>();

        }
        PersonaQueSuma5 personaQueSuma5 = new PersonaQueSuma5();
        RobotFibonacci robotFibonacci = new RobotFibonacci();
        PerroFactorial perroFactorial = new PerroFactorial();
        Cubo cubo = new Cubo();
        Cuadrado cuadrado = new Cuadrado();


        public int GetNumero()
        {
            return numero;
        }

        public void Calcular()
        {
            Random num = new Random();
            int numeroAleatorio = num.Next(1, 6);

            if (numeroAleatorio == 1)
            {
                calculadoras.Add(personaQueSuma5);
                personaQueSuma5.Calcular(numero);

            }
            else if (numeroAleatorio == 2)
            {
                calculadoras.Add(robotFibonacci);
                robotFibonacci.Calcular(numero);

            }
            else if (numeroAleatorio == 3)
            {
                calculadoras.Add(perroFactorial);
                perroFactorial.Calcular(numero);

            }
            else if (numeroAleatorio == 4)
            {
                calculadoras.Add(cubo);
                cubo.Calcular(numero);

            }
            else
            {
                calculadoras.Add(cuadrado);
                cuadrado.Calcular(numero);
            }
        }

        public int PQS5(int number)
        {
            int nuevoNumero = personaQueSuma5.Calcular(number);
            return nuevoNumero;
        }

        public int RF(int number)
        {
            int nuevoNumero = robotFibonacci.Calcular(number);
            return nuevoNumero;
        }

        public int PF(int number)
        {
            int nuevoNumero = perroFactorial.Calcular(number);
            return nuevoNumero;
        }
        public int CUBO(int number)
        {
            int nuevoNumero = cubo.Calcular(number);
            return nuevoNumero;
        }

        public int CUADRADO(int number)
        {
            int nuevoNumero = cuadrado.Calcular(number);
            return nuevoNumero;
        }


    }
}
