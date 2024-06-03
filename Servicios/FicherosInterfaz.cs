using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.ExamenRepeticion.Servicios
{
    internal interface FicherosInterfaz
    {
        public void escribirFicheroErrores(string mensaje);


        public void escribirSeleccion(String mensaje);

        public void leerFichero();
    }
}
