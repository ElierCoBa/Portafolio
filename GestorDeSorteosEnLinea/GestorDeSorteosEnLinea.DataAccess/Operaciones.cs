﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
namespace GestorDeSorteosEnLinea.DataAccess
{
    public class Operaciones
    {

        public Model.Sorteos ConsultarUnSorteo(int Id)
        {

            var laBaseDeDatos = new Context();
            var elResultado = laBaseDeDatos.Sorteos.Find(Id);

            return elResultado;
        }

        public Model.SorteosDetalleVentas ConsultarLosGanadores(int elNumeroComprado)
        {

            var laBaseDeDatos = new Context();
            var elResultado = laBaseDeDatos.SorteosDetalleVentas.FirstOrDefault(x => x.Numero == elNumeroComprado);

            return elResultado;
        }

        public Model.SorteosResultados ConsultarElPrimerLugar(int elPrimerLugar)
        {

            var laBaseDeDatos = new Context();
            var elResultado = laBaseDeDatos.SorteosResultados.FirstOrDefault(x => x.PrimerLugar == elPrimerLugar);

            return elResultado;
        }
        public Model.SorteosResultados ConsultarElSegundoLugar(int elSegundoLugar)
        {

            var laBaseDeDatos = new Context();
            var elResultado = laBaseDeDatos.SorteosResultados.FirstOrDefault(x => x.PrimerLugar == elSegundoLugar);

            return elResultado;
        }
        public Model.SorteosResultados ConsultarElTercerLugar(int elTercerLugar)
        {

            var laBaseDeDatos = new Context();
            var elResultado = laBaseDeDatos.SorteosResultados.FirstOrDefault(x => x.PrimerLugar == elTercerLugar);

            return elResultado;
        }

        public Model.SorteosResultados ConsultarUnResultadoDeSorteo(int Id)
        {

            var laBaseDeDatos = new Context();
            var elResultado = laBaseDeDatos.SorteosResultados.FirstOrDefault(x=>x.IdSorteos == Id);

            return elResultado;
        }
        public Model.AspNetUsers ConsultarUnUsuario(string Id)
        {
            var laBaseDeDatos = new Context();
            var elResultado = laBaseDeDatos.AspNetUsers.Find(Id);

            return elResultado;
        }

		public Model.AspNetUsers ConsultarUnUsuarioPorNombre(string nombre) {
			var laBaseDeDatos = new Context();
			var elResultado = laBaseDeDatos.AspNetUsers.FirstOrDefault(x => x.UserName == nombre);

			return elResultado;
		}

        public Model.SorteosResultados ConsultarUnResultado(int Id)
        {
            var laBaseDeDatos = new Context();
            var elResultado = laBaseDeDatos.SorteosResultados.FirstOrDefault(x => x.IdSorteos == Id);

            return elResultado;
        }


        public Model.SorteosRestricciones ConsultarUnSorteoConRestriccion(int Id)
        {
            var laBaseDeDatos = new Context();
            var elResultado = laBaseDeDatos.SorteosRestricciones.Find(Id);

            return elResultado;
        }

        public Model.SorteosRestricciones ConsultarUnSorteoConRestriccionPorId(int Id)
        {
            var laBaseDeDatos = new Context();
            var elResultado = laBaseDeDatos.SorteosRestricciones.FirstOrDefault(x => x.IdSorteos == Id);

            return elResultado;
        }


        public void EditarUnSorteoConRestriccion(Model.SorteosRestricciones elSorteoConRestriccionAEditar)
        {

            var db = new Context();
            var valorBd = ConsultarUnSorteoConRestriccion(elSorteoConRestriccionAEditar.Id);

            valorBd.MontoMaximo = elSorteoConRestriccionAEditar.MontoMaximo;
            valorBd.Numero = elSorteoConRestriccionAEditar.Numero;

            db.Entry(valorBd).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

        }

        public Model.SorteosDetalleVentas ConsultarUnDetalle(int Id)
        {
            var laBaseDeDatos = new Context();
            var elResultado = laBaseDeDatos.SorteosDetalleVentas.Find(Id);

            return elResultado;
        }

        public Model.SorteosDetalleVentas ConsultarUnDetallePorId(int Id)
        {
            var laBaseDeDatos = new Context();
            var elResultado = laBaseDeDatos.SorteosDetalleVentas.FirstOrDefault(x => x.IdSorteos == Id);

            return elResultado;
        }
        public Model.SorteosHistorico ConsultarUnSorteoHistorico(int Id)
        {
            var laBaseDeDatos = new Context();
            var elResultado = laBaseDeDatos.SorteosHistorico.Find(Id);

            return elResultado;


        }

        public Model.SorteosDetalleVentas ConsultarUnSorteoDeUsuario(int Id)
        {
            var laBaseDeDatos = new Context();
            var elResultado = laBaseDeDatos.SorteosDetalleVentas.Find(Id);

            return elResultado;


        }


        public void AgregarSorteo(GestorDeSorteosEnLinea.Model.Sorteos item)
        {
            var laBaseDeDatos = new Context();
            laBaseDeDatos.Sorteos.Add(item);
            laBaseDeDatos.Entry(item).State = System.Data.Entity.EntityState.Added;
            laBaseDeDatos.SaveChanges();

        }
        public void AgregarResultadoDeSorteo(GestorDeSorteosEnLinea.Model.SorteosResultados elResultado)
        {
            var laBaseDeDatos = new Context();
            laBaseDeDatos.SorteosResultados.Add(elResultado);
            laBaseDeDatos.Entry(elResultado).State = System.Data.Entity.EntityState.Added;
            laBaseDeDatos.SaveChanges();

        }
        public List<Model.Sorteos> ListarSorteos()
        {

            var laBaseDeDatos = new Context();
            var elResultado = from elSorteo in laBaseDeDatos.Sorteos

                              select elSorteo;

            return elResultado.ToList();

        }

        public List<Model.Sorteos> ListarSorteosActivos()
        {
            var laBaseDeDatos = new Context();
            var elResultado = from elSorteo in laBaseDeDatos.Sorteos
                              where elSorteo.Estado == Model.Estados.Activo

                              select elSorteo;

            return elResultado.ToList();

        }
        public List<Model.SorteosDetalleVentas> ListarSorteoDeUsuario(string id)
        {
            var laBaseDeDatos = new Context();
            var elResultado = from elSorteo in laBaseDeDatos.SorteosDetalleVentas
                              where elSorteo.Id_AspNetUser == id

                              select elSorteo;

            return elResultado.ToList();

        }
        public List<Model.Sorteos> ListarSorteosCerrados()
        {
            var laBaseDeDatos = new Context();
            var elResultado = from elSorteo in laBaseDeDatos.Sorteos
                              where elSorteo.Estado == Model.Estados.Cerrado

                              select elSorteo;

            return elResultado.ToList();

        }
        public List<Model.Sorteos> ListarSorteosActivosVigentes()
        {
            var laBaseDeDatos = new Context();
            var elResultado = from elSorteo in laBaseDeDatos.Sorteos
                              where elSorteo.Fecha >= DateTime.Now
                              where elSorteo.Estado == Model.Estados.Activo

                              select elSorteo;

            return elResultado.ToList();

        }
        public List<Model.SorteosHistorico> ListarSorteosHistoricos(int Id)
        {
            var laBaseDeDatos = new Context();
            var elResultado = from elSorteo in laBaseDeDatos.SorteosHistorico
                              where elSorteo.IdSorteo == Id

                              select elSorteo;

            return elResultado.ToList();

        }
        public List<Model.SorteosRestricciones> ListarRestriccionesDeSorteo(int Id)
        {
            var laBaseDeDatos = new Context();
            var elResultado = from laRestriccion in laBaseDeDatos.SorteosRestricciones
                              where laRestriccion.IdSorteos == Id

                              select laRestriccion;

            return elResultado.ToList();

        }



        public void AgregarSorteoHistorico(GestorDeSorteosEnLinea.Model.SorteosHistorico elSorteoHistorico)
        {
            var laBaseDeDatos = new Context();
            laBaseDeDatos.SorteosHistorico.Add(elSorteoHistorico);
            laBaseDeDatos.Entry(elSorteoHistorico).State = System.Data.Entity.EntityState.Added;
            laBaseDeDatos.SaveChanges();

        }
        public void AgregarSorteoHistoricoModificado(GestorDeSorteosEnLinea.Model.SorteosHistorico elSorteoHistorico)
        {
            var laBaseDeDatos = new Context();
            laBaseDeDatos.SorteosHistorico.Add(elSorteoHistorico);
            laBaseDeDatos.Entry(elSorteoHistorico).State = System.Data.Entity.EntityState.Added;
            laBaseDeDatos.SaveChanges();

        }

        public void CambiarDeEstadoUnSorteo(Model.Sorteos elSorteo, Model.SorteosHistorico elSorteoHistorico)
        {
            var elSorteoObtenido = ConsultarUnSorteo(elSorteo.Id);

            var laBaseDeDatos = new Context();
            elSorteoObtenido.Estado = elSorteo.Estado;

            laBaseDeDatos.Entry(elSorteoObtenido).State = System.Data.Entity.EntityState.Modified;
            AgregarSorteoHistoricoModificado(elSorteoHistorico);
            laBaseDeDatos.SaveChanges();

        }


         public void CerrarUnSorteo(Model.Sorteos elSorteo)
        {
            var elSorteoObtenido = ConsultarUnSorteo(elSorteo.Id);

            var laBaseDeDatos = new Context();
            elSorteoObtenido.Estado = elSorteo.Estado;

            laBaseDeDatos.Entry(elSorteoObtenido).State = System.Data.Entity.EntityState.Modified;
            laBaseDeDatos.SaveChanges();

        }

        public void AgregarDetalleVenta(GestorDeSorteosEnLinea.Model.SorteosDetalleVentas elDetalleDeLaVenta)
        {
            var laBaseDeDatos = new Context();
            laBaseDeDatos.SorteosDetalleVentas.Add(elDetalleDeLaVenta);
            laBaseDeDatos.Entry(elDetalleDeLaVenta).State = System.Data.Entity.EntityState.Added;
            laBaseDeDatos.SaveChanges();
        }

        public void AgregarSorteosRestricciones(GestorDeSorteosEnLinea.Model.SorteosRestricciones elSorteoConLasRectricciones)
        {
            var laBaseDeDatos = new Context();
            laBaseDeDatos.SorteosRestricciones.Add(elSorteoConLasRectricciones);
            laBaseDeDatos.Entry(elSorteoConLasRectricciones).State = System.Data.Entity.EntityState.Added;
            laBaseDeDatos.SaveChanges();

        }

        public Decimal ConsultarMontoAcumuladoRestriccion(int numero, int id)
        {
            var laBaseDeDatos = new Context();
            Decimal montoAcumuladoNumero = 0;


            GestorDeSorteosEnLinea.Model.SorteosDetalleVentas MontoAcumuladoRestriccion = laBaseDeDatos.SorteosDetalleVentas.Where(t => t.Numero == numero).Where(j => j.IdSorteos == id).FirstOrDefault();
            if (MontoAcumuladoRestriccion != null)
            { montoAcumuladoNumero = laBaseDeDatos.SorteosDetalleVentas.Where(t => t.Numero == numero).Where(j => j.IdSorteos == id).Sum(x => x.Monto); }


            return montoAcumuladoNumero;

        }
        public GestorDeSorteosEnLinea.Model.SorteosRestricciones PoseeRestriccionElSorteoSeleccionado(int numero, int id)
        {

            var laBaseDeDatos = new Context();
            var elResultado = laBaseDeDatos.SorteosRestricciones.Where(x => x.Numero == numero).Where(j => j.IdSorteos == id).FirstOrDefault();


            return elResultado;
        }





        public Decimal ObtenerElTotalVendidoEnUnSorteo(int Id)
        {
            
            var laBaseDeDatos = new Context();
            var elResultado = laBaseDeDatos.SorteosDetalleVentas.Where(x => x.IdSorteos == Id).Sum(x => x.Monto);

            return elResultado;
        }

        public Decimal ObtenerElTotalPagadoAlPrimerNumeroEnUnSorteo(int id,int primerNumero)
        {

            Decimal elResultado = 0;

            var laBaseDeDatos = new Context();
            try
            {
                elResultado = laBaseDeDatos.SorteosDetalleVentas.Where(x => x.IdSorteos == id).Where(j => j.Numero == primerNumero).Sum(x => x.Monto);
            }
            catch { }
            return elResultado;
        }


        public Decimal ObtenerElTotalPagadoAlSegundoNumeroEnUnSorteo(int id, int segundoNumero)
        {

            Decimal elResultado = 0;

            var laBaseDeDatos = new Context();
            try
            {
             elResultado = laBaseDeDatos.SorteosDetalleVentas.Where(x => x.IdSorteos == id).Where(j => j.Numero == segundoNumero).Sum(x => x.Monto);
            }
            catch { }

            return elResultado;
        }

        public Decimal ObtenerElTotalPagadoAlTercerNumeroEnUnSorteo(int id, int tercerNumero)
        {
            Decimal elResultado = 0;
            var laBaseDeDatos = new Context();
            try
            {
                elResultado = laBaseDeDatos.SorteosDetalleVentas.Where(x => x.IdSorteos == id).Where(j => j.Numero == tercerNumero).Sum(x => x.Monto);
            }
            catch { }
            return elResultado;
        }







    }
}
