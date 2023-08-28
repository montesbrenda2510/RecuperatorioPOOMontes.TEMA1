using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperatorioPOO.Montes
{
   public class Prisma
    {
        private int altura { get; set; }

        private int ancho { get; set; }

        public int largo { get; set; }

        private int AreaBase()
        {
            return largo * ancho;
        }
        private int AreaAltura()
        {
            return altura * ancho;
        }
        private int AreaAncho()
        {
            return altura * largo;
        }
        public Prisma(int Altura, int Ancho, int Largo)
        {
            if (Altura <= 0 && Ancho <= 0 && Largo <= 0)
            {
                throw new ArgumentException("El dato ingresado esta mal");
            }

            altura = Altura;
            ancho = Ancho;
            largo= Largo;


        }

        public int GetArea()
        {
            return 2 * (AreaBase() + AreaAltura() + AreaAncho());
        }
        public int GetVolumen()
        {
            return largo * altura * ancho;
        }
        public double GetDiagonal()
        {
            return Math.Sqrt(Math.Pow(altura,2)+ Math.Pow(ancho,2)+Math.Pow(largo,2));
        }
        public string GetMostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"EL valor de la altura es de ......... {altura.ToString()}");
            sb.AppendLine($"El valor del Largo es de ..... {largo.ToString()}");
            sb.AppendLine($"El valor del ancho es de..... {ancho.ToString()}");
            sb.AppendLine($"EL valor del volumen es....... {GetVolumen().ToString()}");
            sb.AppendLine($"Elvalor del area es ...... {GetArea()}");
            sb.AppendLine($"El valor de la diagonal es ...... {GetDiagonal()}");
            return sb.ToString();
        }
    
      
    }
}
