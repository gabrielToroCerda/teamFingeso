using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                StreamWriter archivo = File.AppendText("BDUsuarios.txt");
                archivo.WriteLine("torito1243;gabriel;toro;19.184.858-6");
                archivo.Close();
                Console.WriteLine("Escritura realizada con éxito.");
            }
            catch
            {
                Console.WriteLine("Se ha fallado en escribir en el archivo");
            }
            Console.ReadKey();
        }
    }
}
