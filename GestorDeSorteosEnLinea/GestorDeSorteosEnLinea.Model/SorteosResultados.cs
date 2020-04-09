using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GestorDeSorteosEnLinea.Model
{
    public class SorteosResultados
    {
        public int Id { get; set; }
        public int IdSorteos { get; set; }

        [Required(ErrorMessage = "El primer número ganador es requerido")]
        [Range(01, 99, ErrorMessage = "El rango de los números es de 01 a 99")]
        [RegularExpression("^\\d+$", ErrorMessage = "No se admiten letras")]
        public int PrimerLugar { get; set; }

        [Required(ErrorMessage = "El segundo número ganador es requerido")]
        [Range(01, 99, ErrorMessage = "El rango de los números es de 01 a 99")]
        [RegularExpression("^\\d+$", ErrorMessage = "No se admiten letras")]
        public int SegundoLugar { get; set; }

        [Required(ErrorMessage = "El tercer número ganador es requerido")]
        [Range(01, 99, ErrorMessage = "El rango de los números es de 01 a 99")]
        [RegularExpression("^\\d+$", ErrorMessage = "No se admiten letras")]
        public int TercerLugar { get; set; }
    }
}
