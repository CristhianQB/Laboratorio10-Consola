using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClases3;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcion = CClase1.MenuPrincipal();
            do
                switch (opcion)
                {
                    case 0:
                        opcion = CClase1.MenuPrincipal();
                        break;
                    case 1:
                        opcion = CClase1.mPhone3000();
                        break;
                    case 2:
                        opcion = CClase1.mPad3500();
                        break;
                    case 3:
                        opcion = CClase1.MAPBrook3800();
                        break;
                    case 4:
                        opcion = CClase1.mWatch8000();
                        break;
                    case 5:
                        opcion = CClase1.MenuFinal();
                        break;
                    case 6:
                        opcion = CClase1.OpcionesdeVenta();
                        break;
                    case 7:
                        opcion = CClase1.OpcionesdeDevolucion();
                        break;
                }
            while (opcion != 8);

        }
    }
}
