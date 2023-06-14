using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_18_siesa
{
    internal class Program
    {
        //creamos el metodo que recibira los parametros
        static string ConvertToBaseK(int x, int k)
        {
            //validamos  si el párametro en base 10 es == 0
            if (x == 0)
            {
                return "0"; // Caso especial cuando x es 0
            }
            //ejecutamos la condicion donde mientras x sea mayor a 0 divida divda los valores ingresados en x y k
            string resultado = "";
            while (x > 0)
            {
                int residuo = x % k;
                resultado = residuo.ToString() + resultado;
                x = x / k;
            }
            return resultado;
        }
           
            static void Main(string[] args)
        {
            //solicitamos el numero en base 10
            Console.Write("Ingrese el número en base 10: ");
            int x = int.Parse(Console.ReadLine());
            //solicitamos el nuermo que se dividara con el numero en base 10
            Console.Write("Ingrese la base k: ");
            int k = int.Parse(Console.ReadLine());
            //mostramos el resultado de la operacion
            string resultado = ConvertToBaseK(x, k);
            Console.WriteLine("El número {0} en base {1} es: {2}", x, k, resultado);
            Console.ReadKey();
        }
    }
}
