using NUnit.Framework;
using Pruebas_Unitarias;
using System.Drawing;
using Xunit;

namespace C_Pruebas_LineasH
{
    [TestFixture]
    public class CVerificadora_de_Lineas_HorizontalesTests
    {
        [Test]
        public void Verificadora_LineaHorizontal_True()
        {
            int[] vertices = { 1, 5, 8, 5 };
            var verificadora = new CVerificadora_de_Lineas_Horizontales(vertices);
            var Resultado = verificadora.Verificadora();
            NUnit.Framework.Assert.IsTrue(Resultado);
        }

        [Test]
        public void Verificadora_LineaNoHorizontal_False()
        {
            int[] vertices = { 5, 10, 15, 20 };
            var verificadora = new CVerificadora_de_Lineas_Horizontales(vertices);
            var Resultado = verificadora.Verificadora();
            NUnit.Framework.Assert.IsFalse(Resultado);
        }

        [Test]
        public void ContieneInclinacion_Inclinacion_True()
        {
            int[] vertices = { 5, 10, 15, 20 };
            var verificadora = new CVerificadora_de_Lineas_Horizontales(vertices);
            var Resultado = verificadora.ContieneInclinacion();
            NUnit.Framework.Assert.IsTrue(Resultado);
        }

        [Test]
        public void ContieneInclinacion_NoInclinacion_False()
        {
            int[] vertices = { 1, 5, 8, 5 };
            var verificadora = new CVerificadora_de_Lineas_Horizontales(vertices);
            var Resultado = verificadora.ContieneInclinacion();
            NUnit.Framework.Assert.IsFalse(Resultado);
        }
    }
}
