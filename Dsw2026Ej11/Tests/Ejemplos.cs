using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
using System.Collections;
namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    public static void EjemploList()
    {

        Console.WriteLine("═══════════════════════════════════════");
        Console.WriteLine("           EJEMPLO LIST");
        Console.WriteLine("═══════════════════════════════════════");

        CasoList listaAlumnos = new CasoList();

        //Agregar 3 alumnos a la lista
        listaAlumnos.AgregarAlumno(new Alumno(1, "Agustin", 8.5));
        listaAlumnos.AgregarAlumno(new Alumno(2, "Veronica", 5.5));
        listaAlumnos.AgregarAlumno(new Alumno(3, "Lautaro", 10));
        //listaAlumnos.AgregarAlumno(new Alumno(4, "Agustin", 6));

        //Listar por consola los alumnos
        Console.WriteLine("════════ LISTA DE ALUMNOS ═══════");
        foreach (var a in listaAlumnos.ObtenerAlumnos())
            Console.WriteLine(a);

        //Buscar por nombre un alumno que exista y mostrar por consola

        Console.WriteLine("\n--- Buscar 'Agustin' ---");
        var encontrado = listaAlumnos.BuscarAlumnoPorNombre("Agustin");
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");//esta linea solo funciona con la segunda implementacion de buscarAlumnoPorNombre


        //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
        Console.WriteLine("\n--- Buscar 'Pedro' ---");
        var noEncontrado = listaAlumnos.BuscarAlumnoPorNombre("Pedro");
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");


        //Eliminar un alumno y listar por consola los alumnos
        Console.WriteLine("\n--- Eliminar 'Veronica' ---");
        var alumnoAEliminar = listaAlumnos.BuscarAlumnoPorNombre("Veronica");
        if (alumnoAEliminar != null)
        {
            listaAlumnos.EliminarAlumno(alumnoAEliminar);
        }
        foreach (var a in listaAlumnos.ObtenerAlumnos())
            Console.WriteLine(a);

        //Eliminar el primer elemento de la lista y listar por consola los alumnos
        Console.WriteLine("\n--- Eliminar el primer elemento ---");
        listaAlumnos.EliminarAlumnoEnPosicion(0);
        foreach (var a in listaAlumnos.ObtenerAlumnos())
            Console.WriteLine(a);

    }

    public static void EjemploDictionary()
    {
        Console.WriteLine("════════ DICTIONARY ═══════");
        CasoDictionary diccionarioAlumnos = new CasoDictionary();

        //Agregar 3 alumnos al diccionario
        diccionarioAlumnos.Agregar(12421, new Alumno(10, "Agustin", 8.5));
        diccionarioAlumnos.Agregar(23322, new Alumno(11, "Veronica", 5.5));
        diccionarioAlumnos.Agregar(31123, new Alumno(12, "Lautaro", 10));

        //Listar por consola los alumnos
        Console.WriteLine("════════ ALUMNOS EN EL DICCIONARIO═══════");
        foreach (var a in diccionarioAlumnos.ObtenerDiccionario())
            Console.WriteLine(a);

        //Buscar un alumno por clave y mostrar por consola
        Console.WriteLine("\n--- Buscar alumno con clave 12421 ---");
        var encontrado = diccionarioAlumnos.Buscar(12421);
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");

        //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
        Console.WriteLine("\n--- Buscar alumno con clave 52295---");
        var noEncontrado = diccionarioAlumnos.Buscar(52295);
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");


        //Eliminar un alumno por clave y listar por consola los alumnos
        Console.WriteLine("\n--- Eliminar alumno con clave 23322 ---");
        diccionarioAlumnos.Eliminar(23322);
        foreach (var a in diccionarioAlumnos.ObtenerDiccionario())
            Console.WriteLine(a);
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {

    }
}
