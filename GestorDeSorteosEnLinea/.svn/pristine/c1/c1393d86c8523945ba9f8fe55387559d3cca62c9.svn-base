using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using GestorDeSorteosEnLinea.Model;

namespace GestorDeSorteosEnLinea.SI
{
   
    public class ServicioDeResultadosDeSorteo : IServicioDeResultadosDeSorteo
    {
        public void AgregarSorteos(SorteosResultados elResultado, SorteosHistorico elSorteoHistorico, Sorteos elSorteo)
        {
            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones;
            elGestorDeOperaciones = new Business.GestorDeOperaciones();
            CerrarUnSorteo(elSorteo, elSorteoHistorico);
            elGestorDeOperaciones.AgregarUnResultado(elResultado);
          

        }
        public void AgregarSorteosHistoricos(SorteosHistorico elSorteoHistorico, int elIdDelSorteo)
        {
            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones;
            elGestorDeOperaciones = new Business.GestorDeOperaciones();
            elGestorDeOperaciones.AgregarSorteosHistoricos(elSorteoHistorico, elIdDelSorteo);
        }
        public SorteosResultados ConsultarUnResultado(int id)
        {
            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones;
            elGestorDeOperaciones = new Business.GestorDeOperaciones();
            GestorDeSorteosEnLinea.Model.SorteosResultados elSorteoAConsultar = new Model.SorteosResultados();

            return elSorteoAConsultar = elGestorDeOperaciones.ConsultarResultadoDeSorteo(id);
        }

   
        public List<Sorteos> ListarResultados()
        {
            List<GestorDeSorteosEnLinea.Model.Sorteos> laListaDeSorteos = new List<Model.Sorteos>();
            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones;
            elGestorDeOperaciones = new Business.GestorDeOperaciones();


            return laListaDeSorteos = elGestorDeOperaciones.ListarSorteosActivosVigentes();
        }

        public void CerrarUnSorteo(Sorteos elSorteo, SorteosHistorico elSorteoHistorico)
        {
            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones;
            elGestorDeOperaciones = new Business.GestorDeOperaciones();
            elGestorDeOperaciones.CerrarUnSorteo(elSorteo, elSorteoHistorico);
        }



        public Decimal ObtenerElTotalVendidoEnUnSorteo(int Id)
        {

            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones;
            elGestorDeOperaciones = new Business.GestorDeOperaciones();

            return elGestorDeOperaciones.ObtenerElTotalVendidoEnUnSorteo(Id);
        }

        public Decimal ObtenerElTotalPagadoAlPrimerNumeroEnUnSorteo(int id, int primerNumero)
        {

            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones;
            elGestorDeOperaciones = new Business.GestorDeOperaciones();

            return elGestorDeOperaciones.ObtenerElTotalPagadoAlPrimerNumeroEnUnSorteo(id, primerNumero);
        }


        public Decimal ObtenerElTotalPagadoAlSegundoNumeroEnUnSorteo(int id, int segundoNumero)
        {

            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones;
            elGestorDeOperaciones = new Business.GestorDeOperaciones();

            return elGestorDeOperaciones.ObtenerElTotalPagadoAlSegundoNumeroEnUnSorteo(id, segundoNumero);
        }

        public Decimal ObtenerElTotalPagadoAlTercerNumeroEnUnSorteo(int id, int tercerNumero)
        {
            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones;
            elGestorDeOperaciones = new Business.GestorDeOperaciones();


            return elGestorDeOperaciones.ObtenerElTotalPagadoAlTercerNumeroEnUnSorteo(id, tercerNumero);
        }












    }
}
