using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_Unitarias
{
	public class CCalculo_De_Descuento
	{
		public decimal Cantidad_vieja { set; get; }
		public int Porcentaje_viejo { set; get; }

		public double Calculo_Dinero_Descontado(int Porcentaje)
		{
			return (double)Cantidad_vieja * ((double)Porcentaje / (double)100);
		}

		public string Comparar_descuentos(double Nuevo_dinero_descontado)
		{
			double Viejo_dinero_descontado = (double)Cantidad_vieja * ((double)Porcentaje_viejo / (double)100);

			if(Nuevo_dinero_descontado > Viejo_dinero_descontado)
			{
				return $"El nuevo descuento es mayor ya que descuenta {Nuevo_dinero_descontado.ToString("C")} contra {Viejo_dinero_descontado.ToString("C")}";
			}
			else if(Nuevo_dinero_descontado < Viejo_dinero_descontado)
			{
				return $"El viejo descuento es mayor  ya que descuenta {Nuevo_dinero_descontado.ToString("C")} contra {Viejo_dinero_descontado.ToString("C")}";
			}
			else
			{
				return $"Los descuentos son iguales, {Nuevo_dinero_descontado} = {Viejo_dinero_descontado}";
			}
		}
	}
}
