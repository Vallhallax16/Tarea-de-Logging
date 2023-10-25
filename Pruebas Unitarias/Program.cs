using log4net.Config;
using log4net;
using Pruebas_Unitarias;
using System.Reflection;
using System.IO;

Console.ForegroundColor = ConsoleColor.Cyan;

short opcion = 0;

//Obtiene una instancia de Log según el proceso actual en ejecución
var Inicializar_Logger = LogManager.GetRepository(Assembly.GetEntryAssembly());

//Configuramos la instancia del log según el XML log4net.config
XmlConfigurator.Configure(Inicializar_Logger, new FileInfo("log4net.config"));

//Iniciamos un logger para este archivo específicamente
var Logger_iniciado = log4net.LogManager.GetLogger(typeof(Program));

while (opcion != 4)
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
			CCalculo_De_Descuento calculo_descuento = new();

			Console.Write("\nIntroduce la cantidad de dinero a emplear: ");
			calculo_descuento.Cantidad_vieja = Convert.ToDecimal(Console.ReadLine());

			Console.Write("\nIntroduce el descuento a realizar a dicha cantidad: ");
			try
			{
				calculo_descuento.Porcentaje_viejo = Convert.ToInt32(Console.ReadLine());
			}
			catch (Exception excepcion)
			{
				Logger_iniciado.Error($"Se tuvo una exepcion del tipo: {excepcion.ToString()}");
			}

			Console.Write("\nIntroduce el nuevo descuento a realizar a dicha cantidad: ");

			int nuevo_porcentaje = 0;

			try
			{
				nuevo_porcentaje = Convert.ToInt32(Console.ReadLine());
			}
			catch (Exception excepcion)
			{
				Logger_iniciado.Fatal($"La excepción ha roto el programa: {excepcion.ToString()}");
			}

			var resultado = calculo_descuento.Comparar_descuentos(calculo_descuento.Calculo_Dinero_Descontado(nuevo_porcentaje,Logger_iniciado),Logger_iniciado);

			Console.WriteLine($"\nResultado de la función: {resultado}");

			Console.WriteLine("\nPresiona enter para continuar...");
			Console.ReadKey();
			break;

		case 2:
			Console.Write("\nIntroduce el numero de iteraciones a realizar: ");
			var iteraciones = Convert.ToInt32(Console.ReadLine());

			//Reporta el número de iteraciones producidas
			Logger_iniciado.Debug($"El usuario introdujo {iteraciones} iteraciones");

			if (iteraciones < 0)
			{
				Logger_iniciado.Error($"El usuario introdujo un multiplicador negativo: {iteraciones}");
			}

			CInteres_Compuesto interes_compuesto = new(iteraciones);

			Console.Write("Introduce la cantidad de dinero a invertir: ");
			var dinero = Convert.ToDecimal(Console.ReadLine());

			Console.Write("Introduce el multiplicador a emplear: ");
			var multiplicador = Convert.ToDecimal(Console.ReadLine());

			//Reporta las cantidades a enviar al método Obtener Ganancias de la clase CInteres_Compuesto
			Logger_iniciado.Debug($"El usuario introdujo: Dinero = {dinero:C} Multiplicador = {multiplicador}\n");

			var ganancias = interes_compuesto.Obtener_Ganancias(multiplicador, dinero, Logger_iniciado);

			Console.WriteLine($"\nSe obtendrían {ganancias.ToString("C")} de ganancias\n");

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
			//Reporta el tipo de opción metió el usuario en el menú para evitar errores
			Logger_iniciado.Warn($"El usuario introdujo {opcion} en el menú");

			Console.ForegroundColor = ConsoleColor.Red;

			Console.WriteLine("Opción errónea, reintentalo de nuevo");
			Thread.Sleep(1000);

			Console.ForegroundColor = ConsoleColor.Cyan;

			break;
	}
}