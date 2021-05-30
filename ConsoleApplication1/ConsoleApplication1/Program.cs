using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            GameWindow ventana = new GameWindow(1024, 500);
            Ventana mostrar = new Ventana(ventana);
        }
    }
}
