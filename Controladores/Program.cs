using edu.PR.ExamenRepeticion.Servicios;
using edu.PR.ExamenRepeticion.Utilidades;
using edu.PR.ExamenRepeticion.Dtos;
using System.Xml.Serialization;


namespace edu.PR.ExamenRepeticion.Controladores
{
    internal class Program
    {
        static public string rutaFichero = "C:\\Users\\Carlo\\OneDrive\\Escritorio\\FICHEROS\\";
        static public string rutaFicheroLogErrores = String.Concat(rutaFichero, Util.nombreFichero());
        static public string rutaFicheroSeleccion = "C:\\Users\\Carlo\\OneDrive\\Escritorio\\FICHEROS\\ficheroSelecciones.txt";
        static public string rutaFicheroPacientes = "C:\\Users\\Carlo\\OneDrive\\Escritorio\\FICHEROS\\pacientes.txt";
        static public List<ClienteDto> listaClientes = new List<ClienteDto>();


        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            FicherosInterfaz fi = new FicherosImplementacion();

            int opcionUsuario;
            bool cerrarMenu = false;

            fi.leerFichero();
            foreach(ClienteDto cliente in listaClientes)
            {
                Console.WriteLine(cliente);
            }

            do
            {
                try
                {
                    opcionUsuario = mi.menuYSeleccionPrincipal();

                    switch (opcionUsuario)
                    {

                        case 0:
                            Console.WriteLine("Has seleccionado cerrar Menu");
                            fi.escribirSeleccion("Has seleccionado cerrar Menu");
                            cerrarMenu = true;
                            break;

                        case 1:

                            Console.WriteLine("Has seleccionado registro de llegada");
                            fi.escribirSeleccion("Has seleccionado registro de llegada");
                            break;

                        case 2:
                            Console.WriteLine("Has seleccionado listado de consultas");
                            fi.escribirSeleccion("Has seleccionado listado de consultas");
                            mi.accesoSubMenu();
                            break;

                        default:
                            fi.escribirSeleccion("ha selecciona una opcion incorrecta");
                            Console.WriteLine("La opcion seleccionado es incorrecta");
                            break;




                    }





                } catch(Exception ex)
                {
                    fi.escribirFicheroErrores("Se ha producido un error" + ex.Message);
                    Console.WriteLine("Se ha producido un erro, intentelo más tarde");
                }

            } while (!cerrarMenu);


        }
    }
}