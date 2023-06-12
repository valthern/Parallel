using _Parallel.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Parallel.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(() => Utilerias.Task1(), () => Utilerias.Task2());
            Console.WriteLine("Proceso finalizado. Presiona una tecla para finalizar.");
        }
    }
}
