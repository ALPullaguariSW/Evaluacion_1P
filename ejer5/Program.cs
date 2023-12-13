/* Ejercicio 5: Programación Orientada a Objetos - Herencia
1. Crea una nueva clase llamada EstudianteGraduado que herede de la clase
Estudiante.
2. Añade una nueva propiedad a EstudianteGraduado llamada Titulo que
almacene el título obtenido.
3. Crea un objeto de tipo EstudianteGraduado llamado graduado1 e inicializa sus
propiedades.
4. Utiliza el método MostrarInformacion de la clase base para mostrar la
información del estudiante graduado.
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

class EstudianteGraduado : Estudiante
{
    //Clase EstudianteGraduado
    public string Titulo { get; set; }

    // Constructor 
    public EstudianteGraduado(string nombre, int edad, double calificacion, string titulo)
        : base(nombre, edad, calificacion)
    {
        Titulo = titulo;
    }
}

class Program
{
    static void Main()
    {
        // Crear un objeto de tipo EstudianteGraduado
        EstudianteGraduado graduado1 = new EstudianteGraduado("AXEL", 26, 20, "INGENIERO EN SOFTWARE");

        // Utilizar el método MostrarInformacion 
        graduado1.MostrarInformacion();
        Console.WriteLine($"Título: {graduado1.Titulo}");
    }
}
