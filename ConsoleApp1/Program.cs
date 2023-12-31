﻿using _Parallel.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Parallel.Plinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = from person in Utilerias.People.AsParallel()
                         where person.City == "Seattle"
                         select person;

            foreach (var person in result)
                Console.WriteLine(person.Name);

            Console.WriteLine("Proceso finalizado. Presiona una tecla para finalizar.");
            Console.ReadKey();
        }
    }
}
