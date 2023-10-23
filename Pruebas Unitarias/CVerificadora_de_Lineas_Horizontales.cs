using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_Unitarias
{
	public class CVerificadora_de_Lineas_Horizontales
	{
		public int[] Vertices = new int[4];

		public CVerificadora_de_Lineas_Horizontales(int[] Coordenadas_vertices) 
		{
			Vertices = Coordenadas_vertices;
		}

		public bool Verificadora()
		{
			if (Vertices[1] == Vertices[3] && Vertices[0] != Vertices[1])
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool ContieneInclinacion()
		{
			if (Vertices[1] != Vertices[3])
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
