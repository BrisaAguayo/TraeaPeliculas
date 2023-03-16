using System;
using System.Collections.Generic;

namespace Pelicula
{
    

    public class Pelicula
    {
        //Campos--
        string titulo;
        string descripcion;
        int duracion;
        int año;
        string director;
        private List<Actor> actores = new List<Actor>();


        //Constructores--
        public static Pelicula(string titulo, int año, string descripcion, string actores, string director, int duracion)


        //Métodos--
     
        public void imprime_Pelicula()
        {
          Console.WriteLine($"{titulo} {año} {descripcion} {actores} {director} {duracion}");

        }

        string titulo {set; get;};
        string descripcion {set; get;);



    }

    public class Actor
    {
        //Propiedades
        string nombre;


        //Constructores


        //Métodos 
        public void Imprime()
        {
            Console.WriteLine($"{Nombre} ({Año})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

class Program 
{
static void Main(){

    Pelicula p1 = new Pelicula();
    p1.SetTitulo("La La Land");
    p1.SetAño(2016);
    Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());

}
} 
    }
}
