﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KazachekI.Sprint0.Task6.V0.Lib;

namespace Tyuiu.KazachekI.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arraynums = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма элементов массива =" + DataService.AdditionArray(arraynums));
            Console.WriteLine("Разность элементов массива =" + DataService.SubtractionArray(arraynums));
            Console.WriteLine("Произведение элементов массива =" + DataService.MultiplicationArray(arraynums));
            Console.ReadKey();
        }
    }
}
