using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuyiu.KazachekI.Sprint0.Task1.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string name = "Иван";
            int age = 21;
            Console.WriteLine ("Здраствуйте меня зовут: " + $"{name}" +  " мне:" + $"{age}"+ " год");
            Console.ReadKey();
        }
    }
}
