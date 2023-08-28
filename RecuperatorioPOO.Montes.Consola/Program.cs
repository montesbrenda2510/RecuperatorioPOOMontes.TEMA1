using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperatorioPOO.Montes.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, PRIMA!");
            Console.WriteLine("Ingrese el valor del ancho del prisma ");
            int ancho = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el valor de la altura del prisma");
            int altura = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el valor del largo del prisma");
            int Largo= int.Parse(Console.ReadLine());
            Prisma prisma = new Prisma(altura, ancho, Largo);

            Console.WriteLine(prisma.GetMostrarDatos());
            Console.ReadLine();
        }
    }
}
