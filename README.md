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

Para la Clase de descuento
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


   
