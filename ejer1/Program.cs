/*
Ejercicio 1: Variables y Operadores en C#
1. Declarar dos variables, numero1 y numero2, e inicialízalas con valores numéricos.
2. Calcula la suma de estas dos variables y almacena el resultado en una tercera
variable llamada resultado.
3. Imprime en la consola el valor de resultado.

 */
using System;

class Program
{
    static void Main()
    {
        // Declaramos dos variables e inicializamos
        int numero1 = 10;
        int numero2 = 5;

        // Calculamos la suma y almacenar el resultado en una tercera variable
        int resultado = numero1 + numero2;

        // Imprimimos el valor de resultado en la consola
        Console.WriteLine("La suma de {0} y {1} es: {2}", numero1, numero2, resultado);
    }
}