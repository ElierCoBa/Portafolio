﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;

namespace GestorDeSorteosEnLinea.Business
{
    public class GestorDeOperaciones
    {


        public void AgregarUsuario(GestorDeSorteosEnLinea.Model.AspNetUsers elUsuario)
        {

            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();


        }

        public void AgregarUnResultado(GestorDeSorteosEnLinea.Model.SorteosResultados elResultado)
        {

            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();
            
            lasOperaciones.AgregarResultadoDeSorteo(elResultado);


        }


        public void EditarUnSorteoConRestriccion(GestorDeSorteosEnLinea.Model.SorteosRestricciones elSorteoConRestriccionAEditar)
        {
            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();
            lasOperaciones.EditarUnSorteoConRestriccion(elSorteoConRestriccionAEditar);

        }

        public GestorDeSorteosEnLinea.Model.Sorteos ConsultarUnSorteo(int Id)
        {
            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();

            return lasOperaciones.ConsultarUnSorteo(Id);

        }

        public GestorDeSorteosEnLinea.Model.SorteosResultados ConsultarResultadoDeSorteo(int Id)
        {
            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();

            return lasOperaciones.ConsultarUnResultadoDeSorteo(Id);

        }
        public GestorDeSorteosEnLinea.Model.AspNetUsers ConsultarUnUsuario(string Id)
        {
            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();

            return lasOperaciones.ConsultarUnUsuario(Id);

        }

		public GestorDeSorteosEnLinea.Model.AspNetUsers ConsultarUnUsuarioPorNombre(string nombre) {
			GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
			lasOperaciones = new DataAccess.Operaciones();

			return lasOperaciones.ConsultarUnUsuarioPorNombre(nombre);

		}

        public GestorDeSorteosEnLinea.Model.SorteosRestricciones ConsultarUnSorteoConRestriccion(int Id)
        {
            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();

            return lasOperaciones.ConsultarUnSorteoConRestriccion(Id);

        }
        public GestorDeSorteosEnLinea.Model.SorteosRestricciones ConsultarUnSorteoConRestriccionPorId(int Id)
        {
            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();

            return lasOperaciones.ConsultarUnSorteoConRestriccionPorId(Id);

        }
        public GestorDeSorteosEnLinea.Model.SorteosDetalleVentas ConsultarUnDetalle(int Id)
        {
            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();

            return lasOperaciones.ConsultarUnDetalle(Id);

        }
        public GestorDeSorteosEnLinea.Model.SorteosDetalleVentas ConsultarUnDetallePorId(int Id)
        {
            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();

            return lasOperaciones.ConsultarUnDetallePorId(Id);

        }
        public void AgregarSorteos(GestorDeSorteosEnLinea.Model.Sorteos elSorteo)
        {
            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();
            lasOperaciones.AgregarSorteo(elSorteo);

        }
        public List<GestorDeSorteosEnLinea.Model.Sorteos> ListarSorteos()
        {
            GestorDeSorteosEnLinea.Model.AspNetUsers elUsuario = new Model.AspNetUsers();
            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();

            return lasOperaciones.ListarSorteos();

        }
        public List<GestorDeSorteosEnLinea.Model.Sorteos> ListarSorteosCerrados()
        {
            GestorDeSorteosEnLinea.Model.AspNetUsers elUsuario = new Model.AspNetUsers();
            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();

            return lasOperaciones.ListarSorteosCerrados();

        }
        public List<GestorDeSorteosEnLinea.Model.SorteosHistorico> ListarSorteosHistoricos(int Id)
        {
            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();

            return lasOperaciones.ListarSorteosHistoricos(Id);

        }

        public List<GestorDeSorteosEnLinea.Model.SorteosRestricciones> ListarRestriccionDeSorteo(int Id)
        {
            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();

            return lasOperaciones.ListarRestriccionesDeSorteo(Id);

        }

        public List<GestorDeSorteosEnLinea.Model.Sorteos> ListarSorteosActivos()
        {
            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();

            return lasOperaciones.ListarSorteosActivos();

        }

        public List<GestorDeSorteosEnLinea.Model.Sorteos> ListarSorteosActivosVigentes()
        {


            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();



            return lasOperaciones.ListarSorteosActivosVigentes();

        }

        public GestorDeSorteosEnLinea.Model.SorteosHistorico ConsultarUnSorteoHistorico(int Id)
        {
            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();

            return lasOperaciones.ConsultarUnSorteoHistorico(Id);

        }
        public void AgregarSorteosHistoricos(GestorDeSorteosEnLinea.Model.SorteosHistorico elSorteoHistorico, int IdSorteo)
        {
            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();
            elSorteoHistorico.IdSorteo = IdSorteo;
            elSorteoHistorico.FechaDeModificacion = DateTime.Now;
            elSorteoHistorico.DescripcionDeLaModificacion = "Registro de sorteo";
            lasOperaciones.AgregarSorteoHistorico(elSorteoHistorico);


        }

        public void ActivarUnSorteo(GestorDeSorteosEnLinea.Model.Sorteos elSorteo, GestorDeSorteosEnLinea.Model.SorteosHistorico elSorteoHistorico, string laDescripcionDeLaModificacion)
        {
            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();

            elSorteo.Estado = Model.Estados.Activo;
            elSorteoHistorico.DescripcionDeLaModificacion = laDescripcionDeLaModificacion;
            elSorteoHistorico.FechaDeModificacion = DateTime.Now;
            elSorteoHistorico.Id = 0;
            elSorteoHistorico.IdSorteo = elSorteo.Id;
            lasOperaciones.CambiarDeEstadoUnSorteo(elSorteo, elSorteoHistorico);

        }
        public void InactivarUnSorteo(GestorDeSorteosEnLinea.Model.Sorteos elSorteo, GestorDeSorteosEnLinea.Model.SorteosHistorico elSorteoHistorico, string laDescripcionDeLaModificacion)
        {
            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();

            elSorteo.Estado = Model.Estados.Inactivo;
            elSorteoHistorico.DescripcionDeLaModificacion = laDescripcionDeLaModificacion;
            elSorteoHistorico.FechaDeModificacion = DateTime.Now;
            elSorteoHistorico.Id = 0;
            elSorteoHistorico.IdSorteo = elSorteo.Id;
            lasOperaciones.CambiarDeEstadoUnSorteo(elSorteo, elSorteoHistorico);

        }

        public void CerrarUnSorteo(GestorDeSorteosEnLinea.Model.Sorteos elSorteo, GestorDeSorteosEnLinea.Model.SorteosHistorico elSorteoHistorico)
        {
            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();

            elSorteo.Estado = Model.Estados.Cerrado;
            elSorteoHistorico.FechaDeModificacion = DateTime.Now;
            elSorteoHistorico.Id = 0;
            elSorteoHistorico.IdSorteo = elSorteo.Id;
            lasOperaciones.CerrarUnSorteo(elSorteo);

        }
        public void AgregarDetalleVenta(GestorDeSorteosEnLinea.Model.SorteosDetalleVentas elDetalleDeLaVenta, int elNumeroComprado, decimal elMontoDelNumeroComprado, DateTime? laFechaDelSorteo)
        {
            string elMensaje = "";
            string elAsunto = "";
            Model.AspNetUsers elUsuario;
            elAsunto = "Compra realizada satisfactoriamente";
            elMensaje = "Le informamos que la compra de su número: " + elNumeroComprado + " para el sorteo " + laFechaDelSorteo.ToString().Substring(0, 10) + " se realizó satisfactoriamente";
            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();
            elDetalleDeLaVenta.Id = 0;
            elDetalleDeLaVenta.Monto = elMontoDelNumeroComprado;
            elDetalleDeLaVenta.Numero = elNumeroComprado;
            lasOperaciones.AgregarDetalleVenta(elDetalleDeLaVenta);
        
			elUsuario = ConsultarUnUsuario(elDetalleDeLaVenta.Id_AspNetUser);
            EnviarCorreo(elMensaje, elAsunto, elUsuario.Email);

        }
        public List<GestorDeSorteosEnLinea.Model.SorteosDetalleVentas> ListarSorteosDeUsuario(string id)
        {
            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();

            return lasOperaciones.ListarSorteoDeUsuario(id);

        }
        public GestorDeSorteosEnLinea.Model.SorteosDetalleVentas ConsultarUnSorteoDeUsuario(int Id)
        {
            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();

            return lasOperaciones.ConsultarUnSorteoDeUsuario(Id);

        }

        public void AgregarSorteosRestricciones(GestorDeSorteosEnLinea.Model.SorteosRestricciones elSorteoconRestriccion)
        {

            GestorDeSorteosEnLinea.Model.SorteosRestricciones elNuevoSorteConRestricciones;
            elNuevoSorteConRestricciones = new GestorDeSorteosEnLinea.Model.SorteosRestricciones();

            elNuevoSorteConRestricciones.MontoMaximo = elSorteoconRestriccion.MontoMaximo;
            elNuevoSorteConRestricciones.Numero = elSorteoconRestriccion.Numero;
            elNuevoSorteConRestricciones.IdSorteos = elSorteoconRestriccion.Id;

            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new GestorDeSorteosEnLinea.DataAccess.Operaciones();

            lasOperaciones.AgregarSorteosRestricciones(elNuevoSorteConRestricciones);

        }

        public int ObtenerElId(List<Model.SorteosDetalleVentas> laListaDeDetalles, Model.SorteosDetalleVentas elDetalleDelSorteo)
        {
            string elDetalleObtenido = "";
            int elIdObtenido = 0;

            foreach (var elDetalle in laListaDeDetalles)
            {

                elDetalleObtenido = elDetalleDelSorteo.Id_AspNetUser;


                if (elDetalleObtenido == "E12")
                {
                    elIdObtenido = elDetalleDelSorteo.IdSorteos;
                    break;
                }
            }
            return elIdObtenido;

        }

	

           public void EnviarCorreo(string elMensajeAEnviar, string elAsunto, string Email )        {
		
		
            MailMessage elCorreo = new MailMessage();
            SmtpClient elClienteSmtp = new SmtpClient("smtp.gmail.com");


            try
            {
     elCorreo.From = new MailAddress("proyectolenguajes2019@gmail.com");
                elCorreo.To.Add(new MailAddress(Email));
				elCorreo.Subject = elAsunto;
                elCorreo.Body = elMensajeAEnviar;
                elCorreo.IsBodyHtml = true;
                

                elClienteSmtp.Host = "smtp.gmail.com";
                elClienteSmtp.Port = 587;

                elClienteSmtp.UseDefaultCredentials = false;
                elClienteSmtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                elClienteSmtp.Credentials = new NetworkCredential("proyectolenguajes2019@gmail.com", "elProyecto19.");
                elClienteSmtp.EnableSsl = true;
                
                elClienteSmtp.Send(elCorreo);
				
		

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
		

			}

			
        }

		public Boolean EnviarCorreoNormal(string Email, string elNombre, string elMensajeAEnviar, string elAsunto, string laContrasena)
		{
		


			Boolean comprobacion = false;
			
			MailMessage elCorreo = new MailMessage();
			SmtpClient elClienteSmtp = new SmtpClient("smtp.gmail.com");


			try
			{
				elCorreo.From = new MailAddress("proyectolenguajes2019@gmail.com");
				elCorreo.To.Add(new MailAddress(Email));
				elCorreo.Subject = elAsunto;
				elCorreo.Body = elMensajeAEnviar;
				elCorreo.IsBodyHtml = true;


				elClienteSmtp.Host = "smtp.gmail.com";
				elClienteSmtp.Port = 587;

				elClienteSmtp.UseDefaultCredentials = false;
				elClienteSmtp.DeliveryMethod = SmtpDeliveryMethod.Network;
				elClienteSmtp.Credentials = new NetworkCredential("proyectolenguajes2019@gmail.com", laContrasena);
				elClienteSmtp.EnableSsl = true;

				elClienteSmtp.Send(elCorreo);
				comprobacion = true;
				return comprobacion;

			}
			catch (Exception e)
			{
				Console.WriteLine(e.StackTrace);
				return false;

			}


		}

		public Decimal ConsultarMontoAcumuladoRestriccion(int Numero, int Id)
        {
            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();

            return lasOperaciones.ConsultarMontoAcumuladoRestriccion(Numero, Id);

        }
        public GestorDeSorteosEnLinea.Model.SorteosRestricciones PoseeRestriccionElSorteoSeleccionado(int Numero, int Id)
        {

            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();

            return lasOperaciones.PoseeRestriccionElSorteoSeleccionado(Numero, Id);

        }

        public float ObtenerMontoGanado(Model.SorteosDetalleVentas elDetalleDeLaVenta, Model.Sorteos elSorteo)
        {
            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();
            float elMontoGanado = 0;
            float elPrimerPremio = 0;
            float elSegundoPremio = 0;
            float elTercerPremio = 0;
            const int elPagoParaElPrimerPremio = 9;
            const int elPagoParaElSegundoPremio = 5;
            const int elPagoParaElTercerPremio = 2;


            var elResultadoObtenido = lasOperaciones.ConsultarUnResultado(elSorteo.Id);

            if (elDetalleDeLaVenta.Numero == elResultadoObtenido.PrimerLugar)
            {

                elPrimerPremio = (float)elDetalleDeLaVenta.Monto * elPagoParaElPrimerPremio;

            }
            if (elDetalleDeLaVenta.Numero == elResultadoObtenido.SegundoLugar)
            {

                elSegundoPremio = (float)elDetalleDeLaVenta.Monto * elPagoParaElSegundoPremio;
            }
            if (elDetalleDeLaVenta.Numero == elResultadoObtenido.TercerLugar)
            {
                elTercerPremio = (float)elDetalleDeLaVenta.Monto * elPagoParaElTercerPremio;

            }

            elMontoGanado = elPrimerPremio + elSegundoPremio + elTercerPremio;


            return elMontoGanado;
        }

        public int ConsultarElPrimerLugar(int elPrimerLugar)
        {
            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();

            return lasOperaciones.ConsultarElPrimerLugar(elPrimerLugar).PrimerLugar;

        }

        public int ConsultarElSegundoLugar(int elSegundoLugar)
        {
            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();

            return lasOperaciones.ConsultarElSegundoLugar(elSegundoLugar).SegundoLugar;

        }

        public int ConsultarElTercerLugar(int elTercerLugar)
        {
            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();

            return lasOperaciones.ConsultarElTercerLugar(elTercerLugar).TercerLugar;

        }

        public GestorDeSorteosEnLinea.Model.SorteosDetalleVentas ConsultarLosGanadores(int elNumeroComprado)
        {
            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();
         
            return lasOperaciones.ConsultarLosGanadores(elNumeroComprado);

        }



        public Decimal ObtenerElTotalVendidoEnUnSorteo(int Id)
        {

            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();

            return lasOperaciones.ObtenerElTotalVendidoEnUnSorteo(Id);
        }

        public Decimal ObtenerElTotalPagadoAlPrimerNumeroEnUnSorteo(int id, int primerNumero)
        {

            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();
         
            return 9*lasOperaciones.ObtenerElTotalPagadoAlPrimerNumeroEnUnSorteo(id, primerNumero);
        }


        public Decimal ObtenerElTotalPagadoAlSegundoNumeroEnUnSorteo(int id, int segundoNumero)
        {

            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();

            return 5*lasOperaciones.ObtenerElTotalPagadoAlSegundoNumeroEnUnSorteo(id, segundoNumero);
        }

        public Decimal ObtenerElTotalPagadoAlTercerNumeroEnUnSorteo(int id, int tercerNumero)
        {
            GestorDeSorteosEnLinea.DataAccess.Operaciones lasOperaciones;
            lasOperaciones = new DataAccess.Operaciones();

            return 2*lasOperaciones.ObtenerElTotalPagadoAlTercerNumeroEnUnSorteo(id, tercerNumero);
        }













    }
    
}
