using System;
using System.Collections.Generic;

public class Program
{
    // Estructura para almacenar los datos de cada jugador
    struct Jugador
    {
        public int Puntos;
        public double Horas;
        public string Nivel;
        public string Mensaje;
    }

    public static void Main(string[] args)
    {
        List<Jugador> listaJugadores = new List<Jugador>();
        string opcion = "";

        // CICLO INFINITO HASTA QUE SE ELIJA SALIR
        while (opcion != "3")
        {
            // Dibujamos el menú siempre al inicio
            Console.WriteLine("\n--- SISTEMA DE GESTIÓN DE JUGADORES ---");
            Console.WriteLine("1. Registrar nuevo jugador");
            Console.WriteLine("2. Ver reporte de colección");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Console.ReadLine();

            if (opcion == "1")
            {
                RegistrarJugador(listaJugadores);
                // Al terminar, el ciclo vuelve arriba y muestra el menú solo
            }
            else if (opcion == "2")
            {
                MostrarReporte(listaJugadores);
                // Al terminar, vuelve al menú
            }
            else if (opcion == "3")
            {
                Console.WriteLine("Cerrando programa...");
            }
            else
            {
                Console.WriteLine("Opción inválida, intente de nuevo.");
            }
        }
    }

    static void RegistrarJugador(List<Jugador> lista)
    {
        Console.WriteLine("\n--- REGISTRO ---");
       
        int puntos;
        while (true)
        {
            Console.Write("Ingrese los puntos: ");
            if (int.TryParse(Console.ReadLine(), out puntos)) break;
            Console.WriteLine("Error: Use números enteros.");
        }

        double horas;
        while (true)
        {
            Console.Write("Ingrese las horas: ");
            if (double.TryParse(Console.ReadLine(), out horas)) break;
            Console.WriteLine("Error: Use números válidos.");
        }

        Console.Write("¿Es premium? (si/no): ");
        string esPremium = Console.ReadLine().ToLower();

        // Lógica de clasificación
        string nivel = "Principiante";
        if (puntos >= 1000) nivel = "Experto";
        else if (puntos >= 500) nivel = "Intermedio";

        if (puntos >= 800) nivel = "Experto VIP";

        string mensaje = (horas > 100) ? "Bonificación activa" : "Sin bonificación";

        // Guardar en la colección (List)
        lista.Add(new Jugador {
            Puntos = puntos,
            Horas = horas,
            Nivel = nivel,
            Mensaje = mensaje
        });

        Console.WriteLine("¡Jugador registrado!");
        Console.WriteLine("------------------------------");
    }

    static void MostrarReporte(List<Jugador> lista)
    {
        Console.WriteLine("\n=== REPORTE ACTUAL ===");
        if (lista.Count == 0)
        {
            Console.WriteLine("La colección está vacía.");
        }
        else
        {
            foreach (var j in lista)
            {
                Console.WriteLine($"- Nivel: {j.Nivel} | Puntos: {j.Puntos} | Horas: {j.Horas} | {j.Mensaje}");
            }
        }
        Console.WriteLine("=======================\n");
    }
}
