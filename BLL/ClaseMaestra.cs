using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public abstract class ClaseMaestra
    {
        public abstract bool Insertar();

        public abstract bool Modificar(int IdModificar);

        public abstract bool Eliminar();

        public abstract bool Buscar(int IdBuscado);

        public abstract DataTable Listar(string Campos, string Condicion, string Orden);

    }
}
