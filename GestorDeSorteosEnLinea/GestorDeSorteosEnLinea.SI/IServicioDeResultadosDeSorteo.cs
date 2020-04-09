using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GestorDeSorteosEnLinea.SI
{
    
    [ServiceContract]
    public interface IServicioDeResultadosDeSorteo
    {
        [OperationContract]
        List<GestorDeSorteosEnLinea.Model.Sorteos> ListarResultados();
        [OperationContract]
        GestorDeSorteosEnLinea.Model.SorteosResultados ConsultarUnResultado(int id);
        [OperationContract]
        void AgregarSorteos(Model.SorteosResultados elResultado, Model.SorteosHistorico elSorteoHistorico, Model.Sorteos elSorteo);
        [OperationContract]
        void AgregarSorteosHistoricos(Model.SorteosHistorico SorteosHistorico, int elIdDelSorteo);
        [OperationContract]
        void CerrarUnSorteo(Model.Sorteos elSorteo, Model.SorteosHistorico elSorteoHistorico);
        [OperationContract]
        Decimal ObtenerElTotalVendidoEnUnSorteo(int Id);
        [OperationContract]
        Decimal ObtenerElTotalPagadoAlPrimerNumeroEnUnSorteo(int id, int segundoNumero);
        [OperationContract]
        Decimal ObtenerElTotalPagadoAlSegundoNumeroEnUnSorteo(int id, int segundoNumero);
        [OperationContract]
        Decimal ObtenerElTotalPagadoAlTercerNumeroEnUnSorteo(int id, int segundoNumero);

    }
}
