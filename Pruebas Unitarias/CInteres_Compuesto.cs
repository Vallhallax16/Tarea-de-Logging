using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_Unitarias
{
	public class CInteres_Compuesto
	{
		private int iteraciones;

		public CInteres_Compuesto(int iteraciones) 
		{
			this.iteraciones = iteraciones;
		}

		//Calcula las ganancias obtenidas según el número de iteraciones, un multiplicador dado y un monto de inversión inicial
		public decimal Obtener_Ganancias(decimal multiplicador, decimal monto_inicial)
		{
			decimal interes_compuesto = monto_inicial;

			for(int i = 0; i < iteraciones; i++) 
			{
				interes_compuesto *= multiplicador;
			}

			return interes_compuesto - monto_inicial;
		}

		public decimal Obtener_Monto_Inicial(decimal multiplicador, decimal a_obtener)
		{
			decimal minimo = a_obtener;

			for(int i = 0; i < iteraciones ;i++)
			{
				minimo /= multiplicador;
			}

			return minimo;
		}
	}
}
