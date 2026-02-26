using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== GameRank - Clasificador de Jugadores ===");

        // Entradas
        Console.Write("Ingrese los puntos del jugador: ");
        int puntos = int.Parse(Console.ReadLine());

        Console.Write("Ingrese las horas jugadas: ");
        double horasJugadas = double.Parse(Console.ReadLine());

        Console.Write("¿Es usuario premium? (true/false): ");
        bool esPremium = bool.Parse(Console.ReadLine());

        string nivel = "";
        string mensaje = "";

        // Clasificación principal
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

        // Regla compuesta 1
        if (esPremium && puntos >= 800)
        {
            nivel = "Experto VIP";
        }

        // Regla compuesta 2
        if (esPremium && horasJugadas > 100)
        {
            mensaje = "Recibe bonificación especial por ser Premium activo.";
        }

        Console.WriteLine("\n=== Resultado ===");
        Console.WriteLine($"Nivel del jugador: {nivel}");
        Console.WriteLine(mensaje);
    }
}

