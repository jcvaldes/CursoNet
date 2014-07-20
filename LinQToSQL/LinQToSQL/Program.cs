using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQToSQL
{
    class Program
    {
        private static VideoClubDataContext context = new VideoClubDataContext();

        static void Main(string[] args)
        {
            Persona persona1 = new Persona()
            {
                Id = -1,
                Nombre = "Juan Carlos",
                Apellido = "Valdes",
                Direccion = "9 de julio 260"
            };
            Persona persona2 = new Persona()
            {
                Id = -1,
                Nombre = "Joaquin",
                Apellido = "Valdes",
                Direccion = "9 de julio 260"
            };

            AgregarPersona(persona1);
            AgregarPersona(persona2);

            ObtenerPersonas().ForEach(x => Console.WriteLine("Id : {0}, Nombre: {1}, Apellido:{2}, Direccion: {3}", x.Id, x.Nombre, x.Apellido, x.Direccion));

            //Eliminando Persona
            Console.WriteLine("Eliminando Persona");
            EliminarPersona(new Persona() { Id = 22 });

            ObtenerPersonas().ForEach(x => Console.WriteLine("Id : {0}, Nombre: {1}, Apellido:{2}, Direccion: {3}", x.Id, x.Nombre, x.Apellido, x.Direccion));
            Console.ReadKey();
        }

        private static void AgregarPersona(Persona persona)
        {
            context.Personas.InsertOnSubmit(persona);
            context.SubmitChanges();
        }

        private static List<Persona> ObtenerPersonas()
        {
            var resultado = from p in context.Personas
                            select p;
        
            return resultado.ToList();
        }

        private static void EliminarPersona(Persona persona)
        {
            Persona pfound = (from p in context.Personas
                         where p.Id == persona.Id
                         select p).SingleOrDefault();

            context.Personas.DeleteOnSubmit(pfound);
            context.SubmitChanges();
        }
    }
}
