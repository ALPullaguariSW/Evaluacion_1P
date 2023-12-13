/*
Ejercicio 2: Estructuras de Control en C#
1. Declara una variable edad e inicialízala con un valor numérico.
2. Utiliza una estructura if para determinar si la persona es mayor de edad (mayor o
igual a 18).
3. Imprime en la consola un mensaje indicando si la persona es mayor de edad o no.

 */
using System;

class Program
{
    static void Main()
    {
        // Declaramos una variable edad y la inicializamos
        int edad = 20; 

        // Estructura if para determinar si la persona es mayor de edad
        if (edad >= 18)
        {
            // Imprimir 
            Console.WriteLine("La persona es mayor de edad.");
        }
        else
        {
            Console.WriteLine("La persona no es mayor de edad.");
        }
    }
}
