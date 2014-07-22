using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VirusDestroy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando Limpieza del Sitio...");
            string path = ConfigurationManager.AppSettings["path"];
            string[] reserved = {".project", ".seetings", ".buildpath" };

             string[] extensions={".php",".txt",".asp",".css",".html"};

            foreach (string file in Directory.GetFiles(path, "*.*", 
                        SearchOption.AllDirectories).Where(
                            f => extensions.Contains(Path.GetExtension(f).ToLower())))
            {
                Clean(file);
                string contents = File.ReadAllText(file);
            }




            Console.WriteLine("Limpieza Finalizada...");
            Console.ReadKey();
       
        }

        private static void Clean(string file)
        {
            string docText;
            using (StreamReader sr = new StreamReader(file, true))
            {
                docText = sr.ReadToEnd();
            }

            Regex regexText = new Regex("dsasdaasdasdasddew4454554453tfesfsdsrgsgsggsgggfssssgsgsgÑ¨¨¨¨¨¨¨¨¨¨");
            Match match = regexText.Match(docText);
            if (match.Success)
            {
                Console.WriteLine("Virus Encontrado en: {0}", file);
                docText = regexText.Replace(docText, "");

                using (StreamWriter sw = new StreamWriter(file))
                {
                    sw.Write(docText);
                }
            }
        }
    }
}
