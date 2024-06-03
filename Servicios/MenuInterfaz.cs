using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.ExamenRepeticion.Servicios
{
    internal interface MenuInterfaz
    {

        /// <summary>
        /// Metodo que se encarga del menu principal de la aplicación
        /// </summary>
        /// <returns></returns>
        public int menuYSeleccionPrincipal();

        public void accesoSubMenu();

    }
}
