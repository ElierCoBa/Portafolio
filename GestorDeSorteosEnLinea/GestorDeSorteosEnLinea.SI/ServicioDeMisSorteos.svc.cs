﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using GestorDeSorteosEnLinea.Model;

namespace GestorDeSorteosEnLinea.SI
{

    public class ServicioDeMisSorteos : IServicioDeMisSorteos
    {
        public SorteosResultados ConsultarResultadoDeSorteo(int Id)
        {
            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones;
            elGestorDeOperaciones = new Business.GestorDeOperaciones();
            GestorDeSorteosEnLinea.Model.SorteosResultados elResultadoAConsultar = new Model.SorteosResultados();

            return elResultadoAConsultar = elGestorDeOperaciones.ConsultarResultadoDeSorteo(Id);
        }

        public Sorteos ConsultarUnSorteo(int id)
        {
            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones;
            elGestorDeOperaciones = new Business.GestorDeOperaciones();
            GestorDeSorteosEnLinea.Model.Sorteos elSorteoAConsultar = new Model.Sorteos();

            return elSorteoAConsultar = elGestorDeOperaciones.ConsultarUnSorteo(id);
        }

        public SorteosDetalleVentas ConsultarUnSorteoDeUsuario(int id)
        {
            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones;
            elGestorDeOperaciones = new Business.GestorDeOperaciones();
            GestorDeSorteosEnLinea.Model.SorteosDetalleVentas elSorteoAConsultar = new Model.SorteosDetalleVentas();

            return elSorteoAConsultar = elGestorDeOperaciones.ConsultarUnDetalle(id);

        }
        public SorteosDetalleVentas ConsultarUnSorteoDeUsuarioPorId(int id)
        {
            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones;
            elGestorDeOperaciones = new Business.GestorDeOperaciones();
            GestorDeSorteosEnLinea.Model.SorteosDetalleVentas elSorteoAConsultar = new Model.SorteosDetalleVentas();

            return elSorteoAConsultar = elGestorDeOperaciones.ConsultarUnDetallePorId(id);

        }

        public List<Sorteos> ListarSorteos()
        {

            List<GestorDeSorteosEnLinea.Model.Sorteos> laListaDeSorteos = new List<Model.Sorteos>();
            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones;
            elGestorDeOperaciones = new Business.GestorDeOperaciones();


            return laListaDeSorteos = elGestorDeOperaciones.ListarSorteos();
        }

        public List<SorteosDetalleVentas> ListarSorteosDeUsuario(string id)
        {
            List<GestorDeSorteosEnLinea.Model.SorteosDetalleVentas> laListaDeSorteos = new List<Model.SorteosDetalleVentas>();
            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones;
            elGestorDeOperaciones = new Business.GestorDeOperaciones();

            return laListaDeSorteos = elGestorDeOperaciones.ListarSorteosDeUsuario(id);
        }

        public int ObtenerElId(List<SorteosDetalleVentas> laListaDeDetalles, SorteosDetalleVentas elDetalleDelSorteo)
        {
            throw new NotImplementedException();
        }

        public float ObtenerMontoGanado(SorteosDetalleVentas elDetalleDeLaVenta, Sorteos elSorteo)
        {
            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones;
            elGestorDeOperaciones = new Business.GestorDeOperaciones();

            return elGestorDeOperaciones.ObtenerMontoGanado(elDetalleDeLaVenta, elSorteo);
        }
    }
}
