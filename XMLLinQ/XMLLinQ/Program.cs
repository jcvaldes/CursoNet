using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XMLLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument _xmlDoc = XDocument.Load("..\\..\\Datos.xml");
        
            var Consulta = from x in _xmlDoc.Descendants("Autor")
                           select new
                           {
                               NombreAutor = (string)x.Element("NombreAutor")
                           };
            foreach (var item in Consulta)
            {
                Console.WriteLine(item.NombreAutor);
            }

            Console.WriteLine("\r\nMuestra Editoriales que contengan ian");
            var Consulta2 = from x in _xmlDoc.Descendants("editorial")
                            where x.Element("NombreEditorial").Value.Contains("ian")
                            select new
                            {
                                NombreEditorial = (string)x.Element("NombreEditorial")
                            };
            foreach (var item in Consulta2)
            {
                Console.WriteLine(item.NombreEditorial);
            }

            Console.WriteLine("\r\nMuestra todos los libros ");

           var Consulta3 = from x in _xmlDoc.Descendants("libro")
                           from z in _xmlDoc.Descendants("Autor")
                           from y in _xmlDoc.Descendants("editorial")
                           where Convert.ToInt32(x.Element("IdAutor").Value) == Convert.ToInt32(z.Element("Id").Value)
                           && Convert.ToInt32(x.Element("IdEditorial").Value) == Convert.ToInt32(y.Element("Id").Value)
                           select new
                           {
                               NombreLibro = (string)x.Element("NombreLibro"),
                               NombreAutor = (string)z.Element("NombreAutor"),
                               NombreEditorial = (string)y.Element("NombreEditorial")
                           };
            foreach (var item in Consulta3)
            {
                Console.WriteLine("———————————–");
                Console.WriteLine(item.NombreAutor);
                Console.WriteLine(item.NombreLibro);
                Console.WriteLine(item.NombreEditorial);
            }

        }
    }
}
