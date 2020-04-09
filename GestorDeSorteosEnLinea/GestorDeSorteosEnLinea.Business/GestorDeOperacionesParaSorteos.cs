using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeSorteosEnLinea.Business
{
    public class GestorDeOperacionesParaSorteos
    {
        public void AgregarUsuario(GestorDeSorteosEnLinea.Model.AspNetUsers item)
        {
            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();
            lasOperaciones.AgregarUsuario(item);

        }
    }
}
