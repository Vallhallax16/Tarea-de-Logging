using Pruebas_Unitarias;

namespace C_Descuentos
{
    public class Test
    {
        private CCalculo_De_Descuento instancia_descuento;

        public Test()
        {
            instancia_descuento = new CCalculo_De_Descuento();
        }

        [Test]
        public void PU_CalculoDescuento()
        {
            int descuento = 20;
            decimal esperado = 0.0M; // Ajusta el valor esperado según la lógica de tu código
            decimal obtenido = Convert.ToDecimal(instancia_descuento.Calculo_Dinero_Descontado(descuento));
            Assert.IsTrue(esperado == obtenido);
        }
    }
}