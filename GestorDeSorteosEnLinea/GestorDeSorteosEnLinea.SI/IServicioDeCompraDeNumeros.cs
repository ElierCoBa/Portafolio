﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GestorDeSorteosEnLinea.SI
{
   
    [ServiceContract]
    public interface IServicioDeCompraDeNumeros
    {
        [OperationContract]
        List<Model.Sorteos> ListarSorteosActivosVigentes();
        [OperationContract]
        Model.Sorteos ConsultarUnSorteo(int id);
        [OperationContract]
        void AgregarDetalleVenta(Model.SorteosDetalleVentas elDetalleDeLaVenta, int elNumeroComprado, Decimal elMontoDelNumeroComprado, int elIdDelSorteo, DateTime? laFechaDelSorteo);
        [OperationContract]
        Decimal ConsultarMontoAcumuladoRestriccion(int Numero, int Id);
        [OperationContract]
       GestorDeSorteosEnLinea.Model.SorteosRestricciones PoseeRestriccionElSorteoSeleccionado(int Numero, int Id);

    }
}
