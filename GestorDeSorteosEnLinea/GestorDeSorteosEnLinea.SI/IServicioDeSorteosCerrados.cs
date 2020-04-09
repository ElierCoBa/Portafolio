using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GestorDeSorteosEnLinea.SI
{
  
    [ServiceContract]
    public interface IServicioDeSorteosCerrados
    {
        [OperationContract]
        List<GestorDeSorteosEnLinea.Model.Sorteos> ListarSorteosCerrados();
        [OperationContract]
        Model.Sorteos ConsultarUnSorteo(int id);
    }
}
