﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _Parallel.Util
{
    public class Utilerias
    {
        public static void Task1()
        {
            Console.WriteLine("Empezando Tarea 1");
            Thread.Sleep(2000);
            Console.WriteLine("Terminando Tarea 1");
        }

        public static void Task2()
        {
            Console.WriteLine("Empezando Tarea 2");
            Thread.Sleep(1000);
            Console.WriteLine("Terminando Tarea 2");
        }

        public static void WorkOnItem(object item) {
            Console.WriteLine("Empezando trabajo en: " + item);
            Thread.Sleep(100);
            Console.WriteLine("Terminando trabajo en: " + item);
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string City { get; set; }
    }
}
