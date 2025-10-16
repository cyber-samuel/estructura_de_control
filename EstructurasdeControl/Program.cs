using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasdeControl
{
    internal class Program
    {
        static void Main(string[] args) //punto inicio
        {
            //tipos de datos
            //int numero1 = 17;
            //string nombre = "garzón"; // siempre comilas dobles
            //char letra = 'l'; // siempre comillas simples
            //decimal precio = 3.14m; // siempre m al final
            //float altura = 1.75f; // siempre f al final
            //bool esverdadero = true;
            //datetime fecha = datetime.now;


            //Estructura de control
            Console.WriteLine("Ingrese su edad: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Su edad es: " + numero);

            Console.WriteLine("ingrese la primera nota");
            Decimal nota1 = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la primera nota");
            Decimal nota2 = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la primera nota");
            Decimal nota3 = Decimal.Parse(Console.ReadLine());

            while nota1, nota2, nota3 > '5.0':
                //la nota 1 eqivale 20%, la segunda 30% y la tercera 50%
                
            Decimal nota1 = nota1 * 0.20;
        }
    }
}
