using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple("Антоновка", "сладкий", "Россия");
            apple.ShowInfo();
            Lemon lemon = new Lemon("Королевский", 1);
            lemon.ShowInfo();
            Console.ReadKey();
        }
    }
}
