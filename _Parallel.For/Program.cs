using _Parallel.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Parallel.For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var items = Enumerable.Range(0, 500).ToArray();

            Parallel.For(0, items.Length, i => Utilerias.WorkOnItem(items[i]));

            Console.WriteLine("Proceso finalizado. Presiona una tecla para finalizar.");
            Console.ReadKey();
        }
    }
}
