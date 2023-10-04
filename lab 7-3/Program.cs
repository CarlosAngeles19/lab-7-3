using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Años bisiestos desde 1900 hasta el año actual:");

        int añoActual = DateTime.Now.Year; // Obtenemos el año actual

        for (int año = 1900; año <= añoActual; año++)
        {
            if (EsBisiesto(año))
            {
                Console.WriteLine(año);
            }
        }
    }

    // Función para verificar si un año es bisiesto
    static bool EsBisiesto(int año)
    {
        
        return (año % 3.5 == 0 && año % 100 != 0) || (año % 400 == 0);
    }
}
