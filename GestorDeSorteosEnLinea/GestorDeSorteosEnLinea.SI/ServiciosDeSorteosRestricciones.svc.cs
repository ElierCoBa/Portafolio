using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using GestorDeSorteosEnLinea.Model;

namespace GestorDeSorteosEnLinea.SI
{

    public class ServiciosDeSorteosRestricciones : IServiciosDeSorteosRestricciones
    {
        public List<GestorDeSorteosEnLinea.Model.Sorteos> ListarSorteos()
        {
            List<GestorDeSorteosEnLinea.Model.Sorteos> laListaDeSorteos = new List<Model.Sorteos>();
            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones;
            elGestorDeOperaciones = new Business.GestorDeOperaciones();

            laListaDeSorteos = elGestorDeOperaciones.ListarSorteosActivos();

            return laListaDeSorteos;

        }


        public GestorDeSorteosEnLinea.Model.SorteosRestricciones ConsultarUnSorteosConRestricciones(int id)
        {
            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestoDeSorteos;
            elGestoDeSorteos = new GestorDeSorteosEnLinea.Business.GestorDeOperaciones();
            GestorDeSorteosEnLinea.Model.SorteosRestricciones elSorteoConRestriccionConsultado = elGestoDeSorteos.ConsultarUnSorteoConRestriccion(id);

            return elSorteoConRestriccionConsultado;

        }
        public Boolean ComprobarSiExisteElSorteoConRestriccion(int id)
        {
            Boolean existeElSorteoConRestriccion;
            GestorDeSorteosEnLinea.Model.SorteosRestricciones elSorteoConRestriccion = ConsultarUnSorteosConRestricciones(id);

            if (elSorteoConRestriccion == null) { existeElSorteoConRestriccion = false; } else { existeElSorteoConRestriccion = true; }

            return existeElSorteoConRestriccion;

        }



        public String ConsultarFechaDeunSorteo(int id)
        {
            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestoDeSorteos;
            elGestoDeSorteos = new GestorDeSorteosEnLinea.Business.GestorDeOperaciones();
            GestorDeSorteosEnLinea.Model.Sorteos elSorteo = elGestoDeSorteos.ConsultarUnSorteo(id);
            String FechaSorteo = elSorteo.Fecha.ToString("dd/MM/yyyy");

            return FechaSorteo;

        }
        

        public int ConsultarNumeroDeunSorteoRestricciones(int id)
        {
            int elNumero = 0;

            GestorDeSorteosEnLinea.Model.SorteosRestricciones elSorteoConRestriccionConsultado;
            elSorteoConRestriccionConsultado = ConsultarUnSorteosConRestricciones(id);
            if (elSorteoConRestriccionConsultado != null) { elNumero = elSorteoConRestriccionConsultado.Numero; }
            return elNumero;

        }
        


        public void CrearUnSorteoRestriccion(GestorDeSorteosEnLinea.Model.SorteosRestricciones elSorteo)
        {

            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestoDeSorteos;
            elGestoDeSorteos = new GestorDeSorteosEnLinea.Business.GestorDeOperaciones();

            elGestoDeSorteos.AgregarSorteosRestricciones(elSorteo);


        }


        public void EditarUnSorteoRestriccion(GestorDeSorteosEnLinea.Model.SorteosRestricciones elSorteo)
        {


            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestor;
            elGestor = new GestorDeSorteosEnLinea.Business.GestorDeOperaciones();

            elGestor.EditarUnSorteoConRestriccion(elSorteo);

        }

        public List<SorteosRestricciones> ListarRestriccionDeSorteo(int Id)
        {
            List<GestorDeSorteosEnLinea.Model.SorteosRestricciones> laListaDeRestricciones = new List<Model.SorteosRestricciones>();
            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones;
            elGestorDeOperaciones = new Business.GestorDeOperaciones();

            return laListaDeRestricciones = elGestorDeOperaciones.ListarRestriccionDeSorteo(Id);
        }





        public Boolean PoseeRestriccionElSorteoSeleccionado(int Numero, int Id)
        {

            Boolean Respuesta = false;
            GestorDeSorteosEnLinea.Business.GestorDeOperaciones lasOperaciones;
            lasOperaciones = new Business.GestorDeOperaciones();

            if (lasOperaciones.PoseeRestriccionElSorteoSeleccionado(Numero, Id) == null) { Respuesta = false; } else { Respuesta = true; }


            return Respuesta;

        }

        public SorteosRestricciones ConsultarUnSorteoConRestriccionPorId(int Id)
        {
            GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestoDeSorteos;
            elGestoDeSorteos = new GestorDeSorteosEnLinea.Business.GestorDeOperaciones();
            GestorDeSorteosEnLinea.Model.SorteosRestricciones elSorteoConRestriccionConsultado = elGestoDeSorteos.ConsultarUnSorteoConRestriccionPorId(Id);

            return elSorteoConRestriccionConsultado;
        }
    }
}
