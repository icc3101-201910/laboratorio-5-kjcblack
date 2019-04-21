using System;



namespace Laboratorio5
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Indique el número de cálculos a realizar");
            int numCalculos = int.Parse(Console.ReadLine());
            int i = 0;
            Console.WriteLine("Ingrese valor inicial: ");
            int numeroInicial = int.Parse(Console.ReadLine());
            Calculadora calculadora = new Calculadora(numeroInicial);
            int numero = calculadora.GetNumero();
            int nuevo = 0;
            while (i < numCalculos)
            {

                Console.WriteLine("--------------------------------");
                Console.WriteLine("Bienvido a calcular lo que quieras: ");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Selecciona una opción:");
                Console.WriteLine("[1] PersonaQueSuma5: ");
                Console.WriteLine("[2] RobotFibonacci");
                Console.WriteLine("[3] PerroFactorial");
                Console.WriteLine("[4] Cubo");
                Console.WriteLine("[5] Cuadrado");
                Console.WriteLine("[6] Cerrar el programa");

                string opcion = Console.ReadLine();
                if (opcion == "1")
                {
                    if (nuevo == 0)
                    {
                        nuevo = calculadora.PQS5(numero);
                        Console.WriteLine(nuevo);
                        i++;
                    }
                    else
                    {
                        Console.WriteLine(calculadora.PQS5(nuevo));
                        i++;
                    }
                }


                else if (opcion == "2")
                {
                    if (nuevo == 0)
                    {
                        nuevo = calculadora.RF(numero);
                        Console.WriteLine(nuevo);
                        i++;
                    }
                    else
                    {
                        Console.WriteLine(calculadora.RF(nuevo));
                        i++;
                    }

                }
                else if (opcion == "3")
                {
                    if (nuevo == 0)
                    {
                        nuevo = calculadora.PF(numero);
                        Console.WriteLine(nuevo);
                        i++;
                    }
                    else
                    {
                        Console.WriteLine(calculadora.PF(nuevo));
                        i++;
                    }

                }
                else if (opcion == "4")
                {
                    if (nuevo == 0)
                    {
                        nuevo = calculadora.CUBO(numero);
                        Console.WriteLine(nuevo);

                        i++;
                    }
                    else
                    {
                        Console.WriteLine(calculadora.CUBO(nuevo));
                        i++;
                    }
                }
                else if (opcion == "5")
                {
                    if (nuevo == 0)
                    {
                        nuevo = calculadora.CUADRADO(numero);
                        Console.WriteLine(nuevo);

                        i++;
                    }
                    else
                    {
                        Console.WriteLine(calculadora.CUADRADO(nuevo));
                        i++;
                    }

                }
                else
                {
                    break;
                }
        

            }
        }
    }
}
