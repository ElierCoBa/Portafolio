using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GestorDeSorteosEnLinea.Model
{
  public class SorteosRestricciones
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El campo número es requerido")]
        [Range(01, 99, ErrorMessage = "El rango de los números es de 01 a 99")]
        [RegularExpression("^\\d+$", ErrorMessage = "No se admiten letras")]
        public int Numero { get; set; }
        [Required(ErrorMessage = "El campo monto es requerido")]
        [Range(1, short.MaxValue, ErrorMessage = "El monto que se desea comprar debe ser mayor a cero")]
        public Decimal MontoMaximo { get; set; }
        public int IdSorteos { get; set; }
 
    }
}
