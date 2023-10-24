using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases3
{
    public class CClase1
    {
        public static int ContadordemPhones = 0;
        public static int ContadormPads = 0;
        public static int ContadorMAPBrooks = 0;
        public static int ContadormWatches = 0;
        static public int Mostrar(string Msje)
        {
            Console.Write(Msje);
            string leer = Console.ReadLine();
            return int.Parse(leer);
        }

        static public int MenuPrincipal()
        {
            Console.Clear();
            Console.Write("================================\n" +
                "Productos de mPhone\n" +
                "================================\n" +
                "1: Ventas de mPhone 3000\n" +
                "2: Ventas de mPad 3500\n" +
                "3: Ventas de MAPBrook 3800\n" +
                "4: Ventas de mWatch 8000\n" +
                "5: Salir\n" +
                "================================\n" +
                "Ingrese una opción: ");
            return Opciones();
        }

        static public int mPhone3000()
        {
            Opciones2("mPhone 3000");
            return Opciones800();
        }

        static public int mPad3500()
        {
            Opciones2("mPad 3500");
            return Opciones800();
        }
        static public int MAPBrook3800()
        {
            Opciones2("MAPBrook 3800");
            return Opciones800();
        }
        static public int mWatch8000()
        {
            Opciones2("mWatch 8000");
            return Opciones800();
        }

        public static int Opciones()
        {
            string opcionTexto = Console.ReadLine();
            return int.Parse(opcionTexto);
        }

        public static int Opciones800()
        {
            int opcion = Opciones();
            if (opcion == 1) return 6;
            if (opcion == 2) return 7;
            if (opcion == 3) return 0;
            return opcion;
        }
        public static int OpcionesdeVenta()
        {
            int opcion = Opciones();
            switch (opcion)
            {
                case 1:
                    CClase1.RegistrarVentamPhones();
                    break;
                case 2:
                    CClase1.RegistrarVentamPads();
                    break;
                case 3:
                    CClase1.RegistrarVentaMAPBrooks();
                    break;
                case 4:
                    CClase1.RegistrarVentamWatches();
                    break;
            }
            return opcion;
        }
        static public int RegistrarVentamPhones()
        {
            RegistrarVentaoDevolucion("Aumentar", "mPhone 3000");
            int opcion = Opciones();
            return Opciones1(ref opcion);
        }
        static public int RegistrarVentamPads()
        {

            RegistrarVentaoDevolucion("Aumentar", "mPad 3500");
            int opcion = Opciones();
            return Opciones2(ref opcion);
        }
        static public int RegistrarVentaMAPBrooks()
        {
            RegistrarVentaoDevolucion("Aumentar", "MAPBrook 3800");
            int opcion = Opciones();
            return Opciones3(ref opcion);
        }
        static public int RegistrarVentamWatches()
        {
            RegistrarVentaoDevolucion("Aumentar", "mWatch 8000");
            int opcion = Opciones();
            return Opciones4(ref opcion);
        }




        private static int Opciones1(ref int opcion)
        {
            if (opcion == 1)
            {
                ContadordemPhones++;
                opcion++;
                RegistrarVentamPhones();
            }
            else if (opcion == 2)
            {
                return mPhone3000();
            }
            return opcion;
        }



        private static int Opciones2(ref int opcion)
        {
            if (opcion == 1)
            {
                ContadormPads++;
                opcion++;
                RegistrarVentamPads();
            }
            else if (opcion == 2)
            {
                return mPad3500();
            }
            return opcion;
        }

        private static int Opciones3(ref int opcion)
        {
            if (opcion == 1)
            {
                ContadorMAPBrooks++;
                opcion++;
                RegistrarVentaMAPBrooks();
            }
            else if (opcion == 2)
            {
                return MAPBrook3800();
            }
            return opcion;
        }
        private static int Opciones4(ref int opcion)
        {
            if (opcion == 1)
            {
                ContadormWatches++;
                opcion++;
                RegistrarVentamWatches();
            }
            else if (opcion == 2)
            {
                return mWatch8000();
            }
            return opcion;
        }






        public static int OpcionesdeDevolucion()
        {
            int opcion = Opciones();
            switch (opcion)
            {
                case 1:
                    CClase1.RegistrarDevolucionmPhones();
                    break;
                case 2:
                    CClase1.RegistrarDevolucionmPads();
                    break;
                case 3:
                    CClase1.RegistrarDevolucionMAPBrooks();
                    break;
                case 4:
                    CClase1.RegistrarDevolucionmWatches();
                    break;
            }
            return opcion;

        }








        static public int RegistrarDevolucionmPhones()
        {
            RegistrarVentaoDevolucion("Devolucion", "mPhone 3000");
            int opcion = Opciones();
            return Opciones5(ref opcion);
        }

        static public int RegistrarDevolucionmPads()
        {
            RegistrarVentaoDevolucion("Devolucion", "mPad 3500");
            int opcion = Opciones();
            return Opciones6(ref opcion);
        }
        static public int RegistrarDevolucionMAPBrooks()
        {
            RegistrarVentaoDevolucion("Devolucion", "MAPBrook 3800");
            int opcion = Opciones();
            return Opciones7(ref opcion);
        }
        static public int RegistrarDevolucionmWatches()
        {
            RegistrarVentaoDevolucion("Devolucion", "mWatch 8000");
            int opcion = Opciones();
            return Opciones8(ref opcion);
        }



        private static int Opciones5(ref int opcion)
        {
            if (opcion == 1)
            {
                ContadordemPhones--;
                opcion++;
                RegistrarDevolucionmPhones();
            }
            else if (opcion == 2)
            {
                return mPhone3000();
            }
            return opcion;
        }

        private static int Opciones6(ref int opcion)
        {
            if (opcion == 1)
            {
                ContadormPads--;
                opcion++;
                RegistrarVentamPads();
            }
            else if (opcion == 2)
            {
                return mPad3500();
            }
            return opcion;
        }

        private static int Opciones7(ref int opcion)
        {
            if (opcion == 1)
            {
                ContadorMAPBrooks--;
                opcion++;
                RegistrarVentaMAPBrooks();
            }
            else if (opcion == 2)
            {
                return MAPBrook3800();
            }
            return opcion;
        }
        private static int Opciones8(ref int opcion)
        {
            if (opcion == 1)
            {
                ContadormWatches--;
                opcion++;
                RegistrarVentamWatches();
            }
            else if (opcion == 2)
            {
                return mWatch8000();
            }
            return opcion;
        }







        static public void RegistrarVentaoDevolucion(string texto, string texto2)
        {
            Console.Clear();
            Console.Write("================================\n" +
                "Registrar " + texto + " de:\n" +
                "================================\n" +
                "Se va a registrar la " + texto + " de un\n" +
                "" + texto2 + " ¿Desea Continuar?\n" +
                "1: Sí\n" +
                "2: No\n" +
                "================================\n" +
                "Ingrese una opción: ");

        }


        private static void Opciones2(string nombre)
        {
            Console.Clear();
            Console.Write("================================\n" +
                "Registrar Venta de" + nombre + "\n" +
                "================================\n" +
                "1: Registrar Venta\n" +
                "2: Registrar Devolución\n" +
                "3: Menu Principal\n" +
                "================================\n" +
                "Ingrese una opción: ");
        }



        public static int MenuFinal()
        {
            int Total = ContadordemPhones + ContadormPads + ContadorMAPBrooks + ContadormWatches;
            Console.Write("================================\n" +
                "Reporte Final\n" +
                "================================\n" +
                "Productos Vendidos | Cantidad\n" +
                "--------------------------------\n" +
                "mPhones         |       " + ContadordemPhones + "\n" +
                "mPads           |       " + ContadormPads + "\n" +
                "MAPBrooks       |       " + ContadorMAPBrooks + "\n" +
                "mWatches        |       " + ContadormWatches + "\n" +
                "--------------------------------\n" +
                "Total           |       " + Total + "\n" +
                "================================\n" +
                "\n" +
                "\n" +
                "\n" +
                "¡Hasta Luego!Diseñado Por: [Cristhian Jean Pierre Quiroz Bernaola]");
            Console.ReadKey();
            return 0;
        }
    }
}