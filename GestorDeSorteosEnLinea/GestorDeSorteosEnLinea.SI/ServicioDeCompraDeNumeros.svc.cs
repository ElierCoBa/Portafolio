﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using GestorDeSorteosEnLinea.Model;

namespace GestorDeSorteosEnLinea.SI
{

    public class ServicioDeCompraDeNumeros : IServicioDeCompraDeNumeros
    {
        public void AgregarDetalleVenta(SorteosDetalleVentas elDetalleDeLaVenta, int elNumeroComprado, decimal elMontoDelNumeroComprado, int elIdDelSorteo, DateTime? laFechaDelSorteo)
        {
            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones;
            elGestorDeOperaciones = new Business.GestorDeOperaciones();
            elDetalleDeLaVenta.IdSorteos = elIdDelSorteo;
            elGestorDeOperaciones.AgregarDetalleVenta(elDetalleDeLaVenta, elNumeroComprado, elMontoDelNumeroComprado, laFechaDelSorteo);
        }

        public Sorteos ConsultarUnSorteo(int id)
        {
            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones;
            elGestorDeOperaciones = new Business.GestorDeOperaciones();
            GestorDeSorteosEnLinea.Model.Sorteos elSorteoAConsultar = new Model.Sorteos();

            return elSorteoAConsultar = elGestorDeOperaciones.ConsultarUnSorteo(id);
        }

        public GestorDeSorteosEnLinea.Model.SorteosRestricciones PoseeRestriccionElSorteoSeleccionado(int Numero, int Id)
        {

            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones;
            elGestorDeOperaciones = new Business.GestorDeOperaciones();

            return elGestorDeOperaciones.PoseeRestriccionElSorteoSeleccionado(Numero, Id);

        }

        public Decimal ConsultarMontoAcumuladoRestriccion(int Numero, int Id)
        {

            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones;
            elGestorDeOperaciones = new Business.GestorDeOperaciones();

            return elGestorDeOperaciones.ConsultarMontoAcumuladoRestriccion(Numero, Id);

        }




        public List<Sorteos> ListarSorteosActivosVigentes()
        {
            List<GestorDeSorteosEnLinea.Model.Sorteos> laListaDeSorteos = new List<Model.Sorteos>();
            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones;
            elGestorDeOperaciones = new Business.GestorDeOperaciones();

            return laListaDeSorteos = elGestorDeOperaciones.ListarSorteosActivosVigentes();
        }
    }
}
