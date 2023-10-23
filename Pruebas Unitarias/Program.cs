using Pruebas_Unitarias;

Console.ForegroundColor = ConsoleColor.Cyan;

short opcion = 0;

while(opcion != 4)
{
	Console.Clear();
	Console.WriteLine("\nSelecciona una clase a probar:\n");
	Console.WriteLine("1. Calculo de descuentos");
	Console.WriteLine("2. Calculo de interes compuesto");
	Console.WriteLine("3. Verificadora de líneas rectas");
	Console.WriteLine("4. Ninguna y salir");
	Console.Write("Opción deseada: ");
	opcion = Convert.ToSByte(Console.ReadLine());

	switch(opcion)
	{
		case 1:
			CCalculo_De_Descuento cdd = new();

			Console.Write("\nIntroduce la cantidad de dinero a emplear: ");
			cdd.Cantidad_vieja = Convert.ToDecimal(Console.ReadLine());

			Console.Write("\nIntroduce el descuento a realizar a dicha cantidad: ");
			cdd.Porcentaje_viejo = Convert.ToInt32(Console.ReadLine());

			Console.Write("\nIntroduce el nuevo descuento a realizar a dicha cantidad: ");
			var nuevo_porcentaje = Convert.ToInt32(Console.ReadLine());

			var resultado = cdd.Comparar_descuentos(cdd.Calculo_Dinero_Descontado(nuevo_porcentaje));

			Console.WriteLine($"\nResultado de la función: {resultado}");

			Console.WriteLine("\nPresiona enter para continuar...");
			Console.ReadKey();
			break;

		case 2:
			Console.Write("\nIntroduce el numero de iteraciones a realizar: ");
			var iteraciones = Convert.ToInt32(Console.ReadLine());

			CInteres_Compuesto cic = new(iteraciones);

			Console.Write("Introduce la cantidad de dinero a invertir: ");
			var dinero = Convert.ToDecimal(Console.ReadLine());

			Console.Write("Introduce el multiplicador a emplear: ");
			var multiplicador = Convert.ToDecimal(Console.ReadLine());

			var ganancias = cic.Obtener_Ganancias(multiplicador, dinero);

			Console.WriteLine($"\nSe obtendrían {ganancias.ToString("C")} de ganancias");

			Console.WriteLine("\nPresiona enter para continuar...");
			Console.ReadKey();
			break;

		case 3:
			int[] vertices = new int[4];

			for(int i = 0; i < 4; i++)
			{
				if(i == 0 || i == 2)
				{
					Console.Write("\nIngresa la coordenada en X del punto: ");
					vertices[i] = Convert.ToInt32(Console.ReadLine());
				}
				else
				{
					Console.Write("\nIngresa la coordenada en Y del punto: ");
					vertices[i] = Convert.ToInt32(Console.ReadLine());
				}
			}

			CVerificadora_de_Lineas_Horizontales cvdlh = new(vertices);

			var es_horizontal = cvdlh.Verificadora();

			if(es_horizontal)
			{
				Console.WriteLine("\nLos puntos dados corresponden a una línea horizontal");
			}
			else
			{
				Console.WriteLine("\nLos puntos dados NO corresponden a una línea horizontal");
			}

			Console.WriteLine("\nPresiona enter para continuar...");
			Console.ReadKey();

			break;

		case 4:

			Console.WriteLine("\nAdios...");
			Thread.Sleep(1000);

			break;

		default:

			Console.ForegroundColor = ConsoleColor.Red;

			Console.WriteLine("Opción errónea, reintentalo de nuevo");
			Thread.Sleep(1000);

			Console.ForegroundColor = ConsoleColor.Cyan;

			break;
	}
}