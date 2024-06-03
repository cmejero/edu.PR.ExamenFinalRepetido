using edu.PR.ExamenRepeticion.Controladores;
using edu.PR.ExamenRepeticion.Dtos;
using edu.PR.ExamenRepeticion.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.ExamenRepeticion.Servicios
{
    internal class FicherosImplementacion : FicherosInterfaz

    {
       
        public void escribirFicheroErrores(string mensaje)
        {
            StreamWriter st = null;
            try
            {
                st = new StreamWriter(Program.rutaFicheroLogErrores, true);

                st.WriteLine(mensaje);
            }catch (IOException io) {
            

                Console.WriteLine("Se ha producido un error, intentelo más tarde");
            }
            finally{

                if(st != null)
                {
                    st.Close();
                }
                
            }
             
        }

        public void escribirSeleccion(String mensaje)
        {

            StreamWriter st = null;

            st = new StreamWriter(Program.rutaFicheroSeleccion, true);

            st.WriteLine(mensaje);

                st.Close() ;

        }

        public void leerFichero()
        {
            StreamReader sr = null;

            try
            {
                sr = new StreamReader(Program.rutaFicheroPacientes);

                string lineas;
                while ((lineas = sr.ReadToEnd()) != null)
                {
                    string[] linea = lineas.Split(';');

                    ClienteDto cliente = new ClienteDto();
                    cliente.Id = crearId();
                    cliente.Dni = linea[0];
                    cliente.NombreCliente = linea[1];
                    cliente.Apellidos = linea[2];
                    cliente.Consulta = linea[3];
                    string fechaFichero = linea[4];
                    cliente.FechaCita = Util.fechaADateTime(fechaFichero);
                    string asistencia = linea[5];
                    cliente.AsistenciaCita = Convert.ToBoolean(asistencia);

                }

                /*
47966922T;Alfonso;Fernández García;Psicología;29-04-2024 12:30:00;true
47166912T;Marta;Fernández Fernández; Psicología; 29-04-2024 13:00:00;false
17165912O;Pedro;Collado Puente; Fisioterapia; 30-04-2024 11:00:00;false
37165912P;Laura;Quintero García; Psicología; 29-04-2024 13:30:00;true
17165912O;Pedro;Collado Puente; Fisioterapia; 29-04-2024 11:00:00;false
37165912P;Laura;Quintero García; Psicología; 25-04-2024 13:30:00;false
                 
                 */


            }
            catch (IOException io)
            {
                escribirFicheroErrores("Se ha producido un error en metodo leer fichero: " + io.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            
            }

        }
        private long crearId()
        {
            long nuevoId;
            int tamanioLista = Program.listaClientes.Count;

            if(tamanioLista > 0)
            {
                nuevoId = Program.listaClientes[tamanioLista - 1].Id + 1;
            }
            else
            {
                nuevoId = 1;
            }
            return nuevoId;

        }
        
    }
}
