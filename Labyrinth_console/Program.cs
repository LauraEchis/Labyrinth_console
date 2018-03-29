using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth
{
    class Program
    {
        static void Main(string[] args)
        {
            MainApp mainApp = new MainApp();
            mainApp.Run("small");
            Console.WriteLine("\r\n");
            mainApp.Run("large");
        }
    }
}