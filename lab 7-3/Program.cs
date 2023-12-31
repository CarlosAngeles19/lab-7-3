﻿using System;

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
// Un año es bisiesto si es divisible por 4,
// pero no es divisible por 100, o si es divisible por 400.
        return (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);
    }
}
