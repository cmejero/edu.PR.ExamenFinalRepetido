using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.ExamenRepeticion.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        FicherosInterfaz fi = new FicherosImplementacion();

        public int menuYSeleccionPrincipal()
        {
            int opcionUsuario;

            Console.WriteLine("#######################");
            Console.WriteLine("0. Cerrar Aplicación");
            Console.WriteLine("1. Registro de llegada");
            Console.WriteLine("2. Listado de consultas");
            Console.WriteLine("#######################");

            opcionUsuario = Convert.ToInt32(Console.ReadLine());
            return opcionUsuario;
        }

       


        private int menuYSeleccionListadoConsultas()
        {
            int opcionUsuario;

            Console.WriteLine("#######################");
            Console.WriteLine("0. Cerrar Aplicación");
            Console.WriteLine("1. mostrar consultas");
            Console.WriteLine("2. Imprimir consultas");
            Console.WriteLine("#######################");

            opcionUsuario = Convert.ToInt32(Console.ReadLine());
            return opcionUsuario;
        }


        public void accesoSubMenu()
        {
            int opcionUsuario;
            bool cerrarMenu = false;

            do
            {
                try
                {
                    opcionUsuario = menuYSeleccionListadoConsultas();

                    switch (opcionUsuario)
                    {

                        case 0:
                            Console.WriteLine("Has seleccionado volver");
                            fi.escribirSeleccion("Has seleccionado volver");
                            cerrarMenu = true;
                            break;

                        case 1:

                            Console.WriteLine("Has seleccionado mostrar consultas");
                            fi.escribirSeleccion("Has seleccionado mostrar consultas");
                            break;

                        case 2:
                            Console.WriteLine("Has seleccionado imprimir consultas");
                            fi.escribirSeleccion("Has seleccionado imprimir consultas");
                            break;

                        default:
                            fi.escribirSeleccion("Ha seleccionado una opcion incorrecta");
                            Console.WriteLine("La opcion seleccionado es incorrecta");
                            break;




                    }





                }
                catch (Exception ex)
                {
                    fi.escribirFicheroErrores("Se ha producido un error" + ex.Message);
                    Console.WriteLine("Se ha producido un erro, intentelo más tarde");
                }

            } while (!cerrarMenu);
        }
    }
}
