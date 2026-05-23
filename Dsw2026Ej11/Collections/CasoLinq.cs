namespace Dsw2026Ej11.Collections;

using Dsw2026Ej11.Domain;
using System.Runtime.CompilerServices;


/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    private List<Libro> libros = Libro.CrearLista();

    //public void AgregarLibro(Libro libro)
    //{
    //    libros.Add(libro);
    //}

    //1
    public Libro? GetPrimero()
    {
        return libros.First();
    }

    //2
    public Libro? GetUltimo()
    {
        return libros.Last();
    }

    //3
    public double GetTotalPrecios()
    {
        return (double)libros.Sum(l => l.Precio);
    }

    //4
    public double GetPromedioPrecios()
    {
        return (double)libros.Average(l => l.Precio);
    }

    //5
    public List<Libro> GetListById(int x)
    {
        return libros.Where(l => l.Id > x).ToList();
    }

    //6
    public List<string> GetLibros()
    {
        return libros.Select(l => $"{l.Titulo} - {l.Precio:C}").ToList();
    }

    //7
    public Libro? GetMayorPrecio()
    {
        return libros.OrderByDescending(l => l.Precio).First();
    }

    //8
    public Libro? GetMenorPrecio()
    {
        return libros.OrderBy(l => l.Precio).First();
    }

    //9
    public List<Libro> GetMayorPromedio()
    {
        double promedio = GetPromedioPrecios();
        return libros.Where(l => l.Precio > (decimal)promedio).ToList();
    }

    //10
    public List<Libro> GetLibrosPorTituloDescendente()
    {
        return libros.OrderByDescending(l => l.Titulo).ToList();
    }
}
