using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace RecuperatorioPOO.Montes.Testing
{
    [TestClass]
    public class TestingPrisma
    {
       [TestMethod]
       public void CrearPrismaValidar()
        {
            int altura = 10;
            int largo = 20;
            int ancho = 30;
            Prisma prisma = new Prisma(altura, ancho, largo);
          
        }
        [TestMethod]
        public void GetAreaTest()
        {
            int altura = 10;
            int largo = 20;
            int ancho = 30;
            
            Prisma prisma = new Prisma(altura, ancho, largo);
            Assert.AreEqual(.ToString(), prisma.GetArea().ToString("N"));
        }
        [TestMethod]
        public void GetVolumenTest()
        {
            int altura = 10;
            int largo = 20;
            int ancho = 30;
            Prisma prisma = new Prisma(altura, ancho, largo);
            Assert.AreEqual(758.45.ToString(), prisma.GetVolumen().ToString("N"));
        }
        [TestMethod]
        public void GetMostrarDatostest()
        {
            int altura = 10;
            int ancho = 30;
            int largo = 20;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"EL valor de la altura es de ......... ");
            sb.AppendLine($"El valor del Largo es de ..... ");
            sb.AppendLine($"El valor del ancho es de..... ");
            sb.AppendLine($"EL valor del volumen es....... ");
            sb.AppendLine($"Elvalor del area es ...... ");
            sb.AppendLine($"El valor de la diagonal es ...... ");
            Prisma prisma = new Prisma(altura, ancho, largo);
            Assert.AreEqual(sb.ToString(), prisma.GetMostrarDatos());
            
        }
    }
   

}