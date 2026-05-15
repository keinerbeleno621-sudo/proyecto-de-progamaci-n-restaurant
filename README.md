JOHN DAIRON SANTANA MUÑOZ 
KEINER JOSE BELEÑO PARRA
1. La Estructura de Datos (struct Jugador)
Es un molde personalizado que sirve para agrupar los datos de un solo jugador en un solo lugar. Tiene las siguientes variables internas (atributos):

Puntos (int): Almacena el puntaje del jugador (número entero).

Horas (double): Almacena las horas de juego (número con decimales).

Nivel (string): Guarda la clasificación del jugador (texto como "Principiante" o "Experto VIP").

Mensaje (string): Guarda el estado de la bonificación (texto).

2. Variables en el Método Principal (Main)
Estas variables controlan el flujo general del programa y la base de datos temporal:

listaJugadores (List<Jugador>): Es una lista dinámica que funciona como la base de datos del programa. Aquí se van guardando uno a uno los Jugador que registres.

opcion (string): Almacena el texto que el usuario escribe en la consola para elegir qué hacer en el menú ("1", "2" o "3").

3. Variables Locales en RegistrarJugador
Estas variables solo existen temporalmente mientras se ejecuta el proceso de registro de un nuevo jugador:

puntos (int): Almacena temporalmente el número que el usuario ingresa para los puntos, tras verificar que sea válido.

horas (double): Almacena temporalmente el número que el usuario ingresa para las horas, tras verificar que sea válido.

esPremium (string): Captura la respuesta del usuario a la pregunta "¿Es premium? (si/no)" y la convierte a minúsculas. (Nota: Actualmente el código la pide pero no la usa para ninguna lógica).

nivel (string): Variable temporal donde se calcula la categoría del jugador según sus puntos mediante condiciones (if/else).

mensaje (string): Variable temporal que evalúa si las horas son mayores a 100 para asignar "Bonificación activa" o "Sin bonificación".

4. Las Funciones (Métodos)
Son los bloques de código que ejecutan las acciones principales del sistema:

Main(string[] args)
¿Qué hace?: Es el punto de partida obligatorio de cualquier programa en C#.

Su función aquí: Controla el ciclo de vida del programa mediante un bucle while. Muestra el menú visual en la consola, lee la opción del usuario y decide si debe llamar a la función de registrar, a la de reportes, o cerrar el programa.

RegistrarJugador(List<Jugador> lista)
¿Qué hace?: Se encarga de pedirle los datos al usuario y añadir un nuevo miembro a la lista.

Su función aquí: 1. Solicita puntos y horas de forma segura (usando int.TryParse y double.TryParse para que el programa no se rompa si el usuario escribe letras).
2. Calcula automáticamente el nivel y el mensaje.
3. Crea un objeto Jugador con esos datos y lo inyecta dentro de la lista que recibió por parámetro.

MostrarReporte(List<Jugador> lista)
¿Qué hace?: Muestra en pantalla de forma ordenada todos los datos acumulados.

Su función aquí: Primero revisa si la lista está vacía (lista.Count == 0). Si tiene datos, usa un ciclo foreach para recorrer a cada jugador guardado y mostrar sus estadísticas en una sola línea estética en la consola.
