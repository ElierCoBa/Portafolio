﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GestorDeSorteosEnLinea.SI
{
    [ServiceContract]
    public interface IServiciosDeSorteosRestricciones
    {
        [OperationContract]
        List<Model.Sorteos> ListarSorteos();
        [OperationContract]
        Model.SorteosRestricciones ConsultarUnSorteosConRestricciones(int id);
        [OperationContract]
        String ConsultarFechaDeunSorteo(int id);
        [OperationContract]
        void CrearUnSorteoRestriccion(GestorDeSorteosEnLinea.Model.SorteosRestricciones elSorteo);
        [OperationContract]
        void EditarUnSorteoRestriccion(GestorDeSorteosEnLinea.Model.SorteosRestricciones elSorteo);
        [OperationContract]
        List<GestorDeSorteosEnLinea.Model.SorteosRestricciones> ListarRestriccionDeSorteo(int Id);
        [OperationContract]
        int ConsultarNumeroDeunSorteoRestricciones(int id);
        [OperationContract]
        Boolean ComprobarSiExisteElSorteoConRestriccion(int id);
        [OperationContract]
        Boolean PoseeRestriccionElSorteoSeleccionado(int Numero, int Id);
        [OperationContract]
        GestorDeSorteosEnLinea.Model.SorteosRestricciones ConsultarUnSorteoConRestriccionPorId(int Id);
    }
}
