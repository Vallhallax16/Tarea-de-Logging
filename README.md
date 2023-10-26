# Tarea-de-Logging
Git dedicado a la tarea de logging para poner en práctica lo visto en clase.

Se usó la librería para C#: Log4Net
Se puede cambiar el nivel del logging en el archivo log4net.config, específicamente en la línea 6:
  <level value = "DEBUG"/>
Y los niveles que puede tomar son:
  ALL
  DEBUG
  INFO
  WARN
  ERROR
  FATAL
  OFF

Líneas agregadas al código:

Para la Clase de descuento:
  -Logging.Info("El método fue llamado y está por retornar un valor");
   Línea de logging de control, para saber que el método Calculo_Dinero_Descontado se ejecutó.

  -Logging.Debug($"Se recibió como parámetro de dinero {Nuevo_dinero_descontado:C}");
   Línea para comprobar qué tipo de dato se recibió en el método Comparar_descuentos.

  -Logging.Warn($"Se introdujo una cantidad erronea de dinero ({Cantidad_vieja:C}), derivará en resultados incorrectos"); 
   Se le notifica al desarrollador que puede haber problemas con los datos porque fueron negativos en el método Comparar_descuentos

  -Logger_iniciado.Error($"Se tuvo una exepcion del tipo: {excepcion.ToString()}");
   Notifica al desarrollador que salió una excepción al capturar un dato del usuario.

  -Logger_iniciado.Fatal($"La excepción ha roto el programa: {excepcion.ToString()}");
   Notifica al desarrollador que los cálculos no se pueden hacer porque el problema se ha roto.

Para la Clase Interés compuesto:
  -Logger.Info("La función Obtener_ganancias está por retornar un valor");
   Línea de logging de control, ayuda a saber en qué momento la función regresará un valor

  -Logger_iniciado.Debug($"El usuario introdujo {iteraciones} iteraciones");
   Línea para observar el dato sensible que el usuario introdujo.
  -Logger_iniciado.Debug($"El usuario introdujo: Dinero = {dinero:C} Multiplicador = {multiplicador}\n");
   Línea para observar los datos enviados al método Obtener_Ganancias.

  -Logger.Warn($"El usuario introdujo un multiplicador {multiplicador}, puede causar errores\n");
   Se le notifica al desarrollador que el multiplicador puede dar datos incorrectos.

  -Logger_iniciado.Error($"El usuario introdujo un multiplicador negativo: {iteraciones}");
   Notifica al desarrollador que un dato ingresado (iteraciones) dará un error en los cálculos.

  -Logger.Fatal($"Hubo una excepción que rompió el programa {expecion.ToString()}");
   Notifica al desarrollador que los cálculos desbordan el tipo de dato y el programa crashea.

   Para la Clase Verificadora de líneas:
  -Logging.Info("Se ha llamado al constructor de la clase");
   Línea de logging de control, notifica que el constructor de la clase se llamó.

  -Logging.Debug($"Valores recibidos del array: {Vertices[0]},{Vertices[1]},{Vertices[2]},{Vertices[3]}\n");
   Línea para mostrar los datos que llegaron al método Verificadora.

  -Logger_iniciado.Warn($"Los datos iguales pueden dar inconsistencias");
   Se notifica que los datos iguales pueden dar un resultado no esperado pero calculable.

  -Logger_iniciado.Error("No se introdujeron los datos de una linea horizontal");
   Notifica que se llegó a un flujo no contemplado y que arrojará un error.

  -Logger_iniciado.Fatal($"Se tuvo una excepcion: {excepcion.ToString()}");	
   Notifica al desarrollador que los datos ingresados crashearon el programa
