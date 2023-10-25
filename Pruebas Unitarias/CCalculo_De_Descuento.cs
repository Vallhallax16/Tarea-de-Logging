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

		public double Calculo_Dinero_Descontado(int Porcentaje, dynamic Logging = null)
		{
			//Línea de logging de control
			Logging.Info("El método fue llamado y está por retornar un valor");

			return (double)Cantidad_vieja * ((double)Porcentaje / (double)100);
		}

		public string Comparar_descuentos(double Nuevo_dinero_descontado, dynamic Logging = null)
		{
			//Línea para comprobar qué tipo de dato se recibió
			Logging.Debug($"Se recibió como parámetro de dinero {Nuevo_dinero_descontado:C}");

			if(Cantidad_vieja < 0)
			{
				//Se le notifica al desarrollador que puede haber problemas con los datos
				Logging.Warn($"Se introdujo una cantidad erronea de dinero ({Cantidad_vieja:C}), derivará en resultados incorrectos");
			}

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
