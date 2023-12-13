/*Ejercicio 4: Programación Orientada a Objetos - Métodos
1. Amplía la clase Estudiante con un método llamado MostrarInformacion que
imprima en la consola los detalles del estudiante.
2. Llama al método MostrarInformacion para el objeto estudiante1 y observa la
salida.
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

    // Métodos 
    public void MostrarInformacion()
    {
        Console.WriteLine("Información del Estudiante:");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad: {Edad} años");
        Console.WriteLine($"Calificación: {Calificacion}");
    }
}

class Program
{
    static void Main()
    {
        // Crear un objeto de tipo Estudiante 
        Estudiante estudiante1 = new Estudiante("Juan", 20, 8.5);
        //Método MostrarInformacion
        estudiante1.MostrarInformacion();
    }
}
