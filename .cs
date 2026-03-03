using System;

	public class Program
	{
		public static void Main(string[] args)
		{
		// Entradas
    Console.Write("Ingrese los puntos del jugador: ");
    int puntos = int.Parse(Console.ReadLine());

    Console.Write("Ingrese las horas jugadas: ");
    double horasJugadas = double.Parse(Console.ReadLine());

    Console.Write("¿Es usuario premium? (si/no): ");
    string esPremium = (Console.ReadLine());

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
    if (esPremium == "si" && puntos >= 800)
    {
        nivel = "Experto VIP";
    }
  
	else		
			
    // Regla compuesta 2
    if (esPremium =="si" && horasJugadas > 100)
    {
        mensaje = "Recibe bonificación especial por ser Premium activo.";
	}
		
			
	// Regla compuesta 3
	
	else
 
	if (esPremium =="no" && horasJugadas > 100)
    {
        mensaje = "Recibe bonificación especial por ser Premium activo.";
	}
	
	else

    // Regla compuesta 4
    if (esPremium == "no" && puntos >= 800)
    {
        nivel = "Experto VIP";
    }
  
			
    Console.WriteLine("\n=== Resultado ===");
    Console.WriteLine($"Nivel del jugador: {nivel}");
    Console.WriteLine(mensaje);
    
		}
	}

