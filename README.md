Importación
using System;

Permite usar funcionalidades básicas del sistema como:

Console.Write()

Console.ReadLine()

Console.WriteLine()

2️⃣ Declaración de la clase y método principal
public class Program
{
    public static void Main(string[] args)

Program es la clase principal.

Main es el punto de inicio del programa.

Todo lo que está dentro de Main es lo que se ejecuta.

3️⃣ Entradas del usuario
Console.Write("Ingrese los puntos del jugador: ");
int puntos = int.Parse(Console.ReadLine());

Pide los puntos.

Convierte la entrada de texto a número entero.

Console.Write("Ingrese las horas jugadas: ");
double horasJugadas = double.Parse(Console.ReadLine());

Pide las horas jugadas.

Convierte el texto en número decimal.

Console.Write("¿Es usuario premium? (si/no): ");
string esPremium = (Console.ReadLine());

Pide si el usuario es premium.

Guarda la respuesta como texto ("si" o "no").

4️⃣ Variables auxiliares
string nivel = "";
string mensaje = "";

nivel almacenará la clasificación del jugador.

mensaje almacenará el mensaje de bonificación si aplica.

🎯 5️⃣ Clasificación principal por puntos
if (puntos >= 1000)
{
    nivel = "Experto";
}
else if (puntos >= 500)
{
    nivel = "Intermedio";
}
else
{
    nivel = "Principiante";
}

El programa clasifica así:

Puntos	Nivel
1000 o más	Experto
500 a 999	Intermedio
Menos de 500	Principiante
🔵 6️⃣ Regla compuesta 1
if (esPremium == "si" && puntos >= 800)
{
    nivel = "Experto VIP";
}

Si:

Es premium

Y tiene 800 o más puntos

Entonces cambia el nivel a "Experto VIP", incluso si antes era Experto o Intermedio.

🔵 7️⃣ Regla compuesta 2
if (esPremium =="si" && horasJugadas > 100)
{
    mensaje = "Recibe bonificación especial por ser Premium activo.";
}

Si:

Es premium

Y ha jugado más de 100 horas

Recibe un mensaje especial.

🔵 8️⃣ Regla compuesta 3
if (esPremium =="no" && horasJugadas > 100)
{
    mensaje = "Recibe bonificación especial por ser Premium activo.";
}

Si:

NO es premium

Y tiene más de 100 horas

También recibe el mismo mensaje de bonificación.

🔵 9️⃣ Regla compuesta 4
if (esPremium == "no" && puntos >= 800)
{
    nivel = "Experto VIP";
}

Si:

No es premium

Y tiene 800 o más puntos

También se le asigna el nivel "Experto VIP".

🖥 10️⃣ Salida del programa
Console.WriteLine("\n=== Resultado ===");
Console.WriteLine($"Nivel del jugador: {nivel}");
Console.WriteLine(mensaje);

Muestra en pantalla:

El nivel final del jugador.

El mensaje de bonificación (si se asignó).

🔄 Resumen en Entrada – Proceso – Salida
🟢 ENTRADA

Puntos del jugador

Horas jugadas

Si es premium ("si" / "no")

🟡 PROCESO

Clasifica por puntos.

Evalúa reglas especiales según:

Tipo de usuario.

Cantidad de puntos.

Horas jugadas.

Puede modificar el nivel inicial.

Puede asignar un mensaje adicional.

🔵 SALIDA

Nivel final del jugador.

Mensaje de bonificación (si aplica).

📊 Tabla Resumen
Sección	Qué hace	Variable afectada
Entradas	Captura datos del usuario	puntos, horasJugadas, esPremium
Clasificación principal	Determina nivel base	nivel
Regla compuesta 1	Puede cambiar a Experto VIP	nivel
Regla compuesta 2	Asigna mensaje premium	mensaje
Regla compuesta 3	Asigna mensaje no premium	mensaje
Regla compuesta 4	Puede cambiar nivel no premium	nivel
Salida	Muestra resultados	nivel, mensaje

