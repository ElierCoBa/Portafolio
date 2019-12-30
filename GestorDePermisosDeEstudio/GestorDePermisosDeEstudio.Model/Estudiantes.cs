using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDePermisosDeEstudio.Model
{
   public class Estudiantes
    {
        public string Id { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public DateTime? FechaDeNacimiento { get; set; }
    }
}
