using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.Core
{
    public class FilaSeleccionada
    {
        Dictionary<String, Object> datos = new Dictionary<String, Object>();

        public void addDato(String columna, Object contenido)
        {
            this.datos.Add(columna, contenido);
        }

        public void removeDatos()
        {
            this.datos.Clear();
        }

        public Object getDato(String columna)
        {
            return this.datos[columna];
        }

    }

}
