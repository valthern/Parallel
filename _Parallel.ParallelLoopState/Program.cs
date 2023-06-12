using _Parallel.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Parallel._ParallelLoopState
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var items=Enumerable.Range(0,500).ToArray();

            ParallelLoopResult result = Parallel.For(0, items.Count(), (int i, ParallelLoopState loopState) =>
            {
                if (i == 200) loopState.Break();

                Utilerias.WorkOnItem(items[i]);
            });

            Console.WriteLine("Completado: " + result.IsCompleted);
            Console.WriteLine("Items: " + result.LowestBreakIteration);
            Console.WriteLine("Proceso finalizado. Presione una tecla para finalizar.");
            Console.ReadKey();
        }
    }
}
