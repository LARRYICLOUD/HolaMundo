using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class Program    {
        static void Main(string[] args)        {
            Console.WriteLine("HOLA MUNDO SOY UN PROGRAMADOR EXCELENTE EN C#");

            //variables
            decimal num1, num2, resultado = 0.0M;
            byte opcion;

            //mostramos el menu
            Console.WriteLine("1.  Suma");
            Console.WriteLine("2.  Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");

            //pedimos al usuario que escoja una opcion
            Console.Write("Escoge una opcion:   ");
            opcion = Convert.ToByte(Console.ReadLine());
            //pedimos el primer numero
            Console.Write("Dame el primer numero:   ");
            num1 = Convert.ToDecimal(Console.ReadLine());
            //pedimos el segundo numero
            Console.Write("dame el segundo numero:  ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            switch(opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                
                   
                case 2:
                    resultado = num1 - num2;
                
                    break;

                case 3:
                    resultado = num1 * num2;
                    break;

                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("No es posible dividir entre cero");
                    }
                    break;
                    default:
                    Console.WriteLine("escoje una opcion valida");
                    break;



            }
            Console.WriteLine("El resultado es : {0}", resultado);

            

            //Console.ReadKey(); //linea para mantener la consola abierta
        }

    }
}