using Pruebas_Unitarias;

namespace PruebaParaInteresCompuesto
{
	public class Tests
	{
		CInteres_Compuesto instancia_interes_compuesto;

        [SetUp]
		public void Setup()
		{
			instancia_interes_compuesto = new CInteres_Compuesto(5);
		}

		[Test]
		public void PU_Normal()
		{
			decimal multiplicador = 1.10M;
			decimal monto = 50M;
			decimal esperado = 30.5255M;
			decimal obtenido = instancia_interes_compuesto.Obtener_Ganancias(multiplicador,monto);
			Assert.AreEqual(esperado, obtenido);
		}

		[Test]
		public void PU_DePrecision()
		{
			decimal multiplicador = 1.39M;
			decimal monto = 133.59M;
			decimal esperado = 559.593076333941M;
			decimal obtenido = instancia_interes_compuesto.Obtener_Ganancias(multiplicador,monto);
			Assert.AreEqual(esperado,obtenido);
		}

		[Test]
		public void PU_NormalF2()
		{
			decimal multiplicador = 1.20M;
			decimal a_obtener = 248.832M;
			decimal esperado = 100M;
			decimal obtenido = instancia_interes_compuesto.Obtener_Monto_Inicial(multiplicador,a_obtener);
			Assert.AreEqual(esperado ,obtenido);
		}

		[Test]
		public void PU_DePrecisionF2()
		{
			decimal multiplicador = 1.73M;
			decimal a_obtener = 1573.1934325M;
			decimal esperado = 101.52M;
			decimal obtenido = instancia_interes_compuesto.Obtener_Monto_Inicial(multiplicador,a_obtener);
			Assert.AreEqual (esperado ,obtenido);	
		}
	}
}