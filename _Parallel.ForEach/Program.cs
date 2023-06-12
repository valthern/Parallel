using _Parallel.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Parallel.ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var items = Enumerable.Range(0, 500);
            Parallel.ForEach(items, item => Utilerias.WorkOnItem(item));

            Console.WriteLine("Proceso finalizado. Presiona una tecla para finalizar.");
            Console.ReadKey();
        }
    }
}
