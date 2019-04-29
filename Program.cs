using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("           ==================================================== ");
            Console.WriteLine();
            Console.WriteLine("                     Selamat Datang di Burjo Simbah 99          ");
            Console.WriteLine();
            Console.WriteLine("           ==================================================== ");
            Console.WriteLine();
            Console.WriteLine("                              Tekan |Enter|                     ");
            Console.ReadKey();
            Console.Clear();

            Menu menu = new Menu();
            menu.Display();
        }
    }
}
