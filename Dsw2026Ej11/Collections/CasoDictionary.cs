
using Dsw2026Ej11.Domain;
namespace Dsw2026Ej11.Collections;


public class CasoDictionary
{
    //Crear un diccionario donde la clave sea el legajo y el valor el alumno
    private Dictionary<int, Alumno> alumnos = new Dictionary<int, Alumno>();

    //Incluir un método para agregar un alumno al diccionario
    public void Agregar(int legajo, Alumno alumno)
    {
        alumnos[legajo] = alumno;
    }

    //Incluir un método para buscar un alumno utilizando la clave
    public Alumno? Buscar(int legajo)
    {
        if (alumnos.TryGetValue(legajo, out Alumno? alumno))
        {
            return alumno;
        }
        return null;
    } 

    //Incluir un método para retornar el diccionario
    public Dictionary<int, Alumno> ObtenerDiccionario()
    {
        return alumnos;
    }

    //Incluir un método para eliminar un alumno utilizando la clave
    public void Eliminar(int legajo)
    {
        alumnos.Remove(legajo);
    }
}
