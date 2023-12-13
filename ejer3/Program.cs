/*
 * Ejercicio 3: Programación Orientada a Objetos - Clases y Objetos
1. Crea una clase llamada Estudiante con propiedades como Nombre, Edad y
Calificacion.
2. Crea un objeto de tipo Estudiante llamado estudiante1 e inicializa sus
propiedades con valores ficticios.
3. Imprime en la consola la información del estudiante.

 */
using System;

class Estudiante
{
    // Clase Estudiante
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public double Calificacion { get; set; }

    // Constructor 
    public Estudiante(string nombre, int edad, double calificacion)
    {
        Nombre = nombre;
        Edad = edad;
        Calificacion = calificacion;
    }
}

class Program
{
    static void Main()
    {
        // Crear un objeto de tipo Estudiante y inicializar sus propiedades
        Estudiante estudiante1 = new Estudiante("Juan", 27, 14);

        // Imprimir en la consola la información del estudiante
        Console.WriteLine("Información del Estudiante:");
        Console.WriteLine($"Nombre: {estudiante1.Nombre}");
        Console.WriteLine($"Edad: {estudiante1.Edad} años");
        Console.WriteLine($"Calificación: {estudiante1.Calificacion}");

    }
}
