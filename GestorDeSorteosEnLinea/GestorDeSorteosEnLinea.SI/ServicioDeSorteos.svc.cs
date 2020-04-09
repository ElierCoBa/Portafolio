﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using GestorDeSorteosEnLinea.Model;

namespace GestorDeSorteosEnLinea.SI
{

    public class ServicioDeSorteos : IServicioDeSorteos
    {
        public void ActivarUnSorteo(Sorteos elSorteo, SorteosHistorico elSorteoHistorico, string laDescripcionDeLaModificacion)
        {
            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones;
            elGestorDeOperaciones = new Business.GestorDeOperaciones();
            elGestorDeOperaciones.ActivarUnSorteo(elSorteo, elSorteoHistorico, laDescripcionDeLaModificacion);
        }

        public void AgregarSorteos(Sorteos elSorteo, SorteosHistorico elSorteoHistorico)
        {

            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones;
            elGestorDeOperaciones = new Business.GestorDeOperaciones();
            elGestorDeOperaciones.AgregarSorteos(elSorteo);
            AgregarSorteosHistoricos(elSorteoHistorico, elSorteo.Id);

        }

        public void AgregarSorteosHistoricos(SorteosHistorico elSorteoHistorico, int elIdDelSorteo)
        {
            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones;
            elGestorDeOperaciones = new Business.GestorDeOperaciones();
            elGestorDeOperaciones.AgregarSorteosHistoricos(elSorteoHistorico, elIdDelSorteo);
        }

        public Sorteos ConsultarUnSorteo(int id)
        {
            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones;
            elGestorDeOperaciones = new Business.GestorDeOperaciones();
            GestorDeSorteosEnLinea.Model.Sorteos elSorteoAConsultar = new Model.Sorteos();

            return elSorteoAConsultar = elGestorDeOperaciones.ConsultarUnSorteo(id);
        }

        public AspNetUsers ConsultarUnUsuario(string id)
        {
            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones;
            elGestorDeOperaciones = new Business.GestorDeOperaciones();
            GestorDeSorteosEnLinea.Model.AspNetUsers elUsuarioAConsultar = new Model.AspNetUsers();

            return elUsuarioAConsultar = elGestorDeOperaciones.ConsultarUnUsuario(id);
        }

        public void InactivarUnSorteo(Sorteos elSorteo, SorteosHistorico elSorteoHistorico, string laDescripcionDeLaModificacion)
        {
            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones;
            elGestorDeOperaciones = new Business.GestorDeOperaciones();
            elGestorDeOperaciones.InactivarUnSorteo(elSorteo, elSorteoHistorico, laDescripcionDeLaModificacion);
        }

        public List<Sorteos> ListarSorteosCerrados()
        {
            List<GestorDeSorteosEnLinea.Model.Sorteos> laListaDeSorteos = new List<Model.Sorteos>();
            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones;
            elGestorDeOperaciones = new Business.GestorDeOperaciones();

            return laListaDeSorteos = elGestorDeOperaciones.ListarSorteosCerrados();
        }

        public List<SorteosHistorico> ListarSorteosHistoricos(int elIdDelSorteoEnviado)
        {
            int elIdSorteo = 0;
            List<GestorDeSorteosEnLinea.Model.SorteosHistorico> laListaDeSorteos = new List<Model.SorteosHistorico>();
            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones;
            elGestorDeOperaciones = new Business.GestorDeOperaciones();
            elIdSorteo = elGestorDeOperaciones.ConsultarUnSorteo(elIdDelSorteoEnviado).Id;
            return laListaDeSorteos = elGestorDeOperaciones.ListarSorteosHistoricos(elIdSorteo);
        }

        List<Sorteos> IServicioDeSorteos.ListarSorteos()
        {
            List<GestorDeSorteosEnLinea.Model.Sorteos> laListaDeSorteos = new List<Model.Sorteos>();
            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones;
            elGestorDeOperaciones = new Business.GestorDeOperaciones();

            return laListaDeSorteos = elGestorDeOperaciones.ListarSorteos();
        }
    }
}
