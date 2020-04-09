using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GestorDeSorteosEnLinea.SI
{

    [ServiceContract]
    public interface IServicioDeMisSorteos
    {
        [OperationContract]
        List<Model.SorteosDetalleVentas> ListarSorteosDeUsuario(string id);
        [OperationContract]
        Model.SorteosDetalleVentas ConsultarUnSorteoDeUsuario(int id);
        [OperationContract]
        List<Model.Sorteos> ListarSorteos();
        [OperationContract]
        Model.Sorteos ConsultarUnSorteo(int id);
        [OperationContract]
        int ObtenerElId(List<Model.SorteosDetalleVentas> laListaDeDetalles, Model.SorteosDetalleVentas elDetalleDelSorteo);
        [OperationContract]
        Model.SorteosResultados ConsultarResultadoDeSorteo(int Id);
        [OperationContract]
        float ObtenerMontoGanado(Model.SorteosDetalleVentas elDetalleDeLaVenta, Model.Sorteos elSorteo);
    }
}
