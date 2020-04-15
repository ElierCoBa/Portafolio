using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Net;
using System.Net.Mail;

namespace GestorDePermisosDeEstudio.Business
{
   public class GestorDeOperaciones
    {
       

        public int EncontrarId(string elCarneResidente, string elCarneEstudiante, DateTime laHora)
        {
            GestorDePermisosDeEstudio.DataAccess.Operaciones lasOperaciones = new DataAccess.Operaciones();
            var elIdBuscado = lasOperaciones.EncontrarId(elCarneResidente, elCarneEstudiante, laHora);

            return elIdBuscado;
        }

        public int EncontrarIdAEliminar(string elCarneResidente)
        {
            GestorDePermisosDeEstudio.DataAccess.Operaciones lasOperaciones = new DataAccess.Operaciones();
            var elIdBuscado = lasOperaciones.EncontrarIdAEliminar(elCarneResidente);

            return elIdBuscado;
        }
        public int EncontrarPermisos(string elCarne)
        {
            GestorDePermisosDeEstudio.DataAccess.Operaciones lasOperaciones = new DataAccess.Operaciones();
            var elIdBuscado = lasOperaciones.EncontrarPermisos(elCarne);

            return elIdBuscado;
        }
        public void InsertarResidente(string elCarne, string elApellido1, string elApellido2, string elNombre1, string elNombre2)
        {
            GestorDePermisosDeEstudio.DataAccess.Operaciones lasOperaciones = new DataAccess.Operaciones();
            lasOperaciones.InsertarResidente(elCarne, elApellido1, elApellido2, elNombre1, elNombre2);

        }
        public void ActualizarResidente(string elCarne, string elApellido1, string elApellido2, string elNombre1, string elNombre2)
        {
            GestorDePermisosDeEstudio.DataAccess.Operaciones lasOperaciones = new DataAccess.Operaciones();
            lasOperaciones.ActualizarResidente(elCarne, elApellido1, elApellido2, elNombre1, elNombre2);

        }
        public void InsertarEstudiante(string elCarne, string elApellido1, string elApellido2, string elNombre1, string elNombre2)
        {
            GestorDePermisosDeEstudio.DataAccess.Operaciones lasOperaciones = new DataAccess.Operaciones();
            lasOperaciones.InsertarEstudiante(elCarne, elApellido1, elApellido2, elNombre1, elNombre2);

        }
        public void InsertarCuarto(string elPabellon, string elCuarto, string elCarne)
        {
            GestorDePermisosDeEstudio.DataAccess.Operaciones lasOperaciones = new DataAccess.Operaciones();
            lasOperaciones.InsertarCuarto(elPabellon, elCuarto, elCarne);

        }
        public void ActualizarCuarto(string elPabellon, string elCuarto, string elCarne)
        {
            GestorDePermisosDeEstudio.DataAccess.Operaciones lasOperaciones = new DataAccess.Operaciones();
            lasOperaciones.ActualizarCuarto(elPabellon, elCuarto, elCarne);

        }
       
        public void InsertarPermisoHistorico(int elId, string elCarneResidente, string elCarneEstudiante, DateTime laFecha, DateTime laHoraDeEntrada, DateTime laHoraDeSalida)
        {
            GestorDePermisosDeEstudio.DataAccess.Operaciones lasOperaciones = new DataAccess.Operaciones();
            lasOperaciones.InsertarPermisoHistorico(elId, elCarneResidente, elCarneEstudiante, laFecha, laHoraDeEntrada, laHoraDeSalida);
        }
        public void InsertarEstado(int elIdPermiso, string elEstado)
        {
            GestorDePermisosDeEstudio.DataAccess.Operaciones lasOperaciones = new DataAccess.Operaciones();
            lasOperaciones.InsertarEstado(elIdPermiso, elEstado);
            
        }
        public void EliminarResidente(string elCarne)
        {
            GestorDePermisosDeEstudio.DataAccess.Operaciones lasOperaciones = new DataAccess.Operaciones();
            lasOperaciones.EliminarResidente(elCarne);
        }
        public void EliminarCuarto(string elCarne)
        {
            GestorDePermisosDeEstudio.DataAccess.Operaciones lasOperaciones = new DataAccess.Operaciones();
            lasOperaciones.EliminarCuarto(elCarne);
        }
        public void EliminarPermisos(int elIdPermiso)
        {
            GestorDePermisosDeEstudio.DataAccess.Operaciones lasOperaciones = new DataAccess.Operaciones();
            lasOperaciones.EliminarPermisos(elIdPermiso);
        }
        public void EliminarEstados(int elIdPermiso)
        {
            GestorDePermisosDeEstudio.DataAccess.Operaciones lasOperaciones = new DataAccess.Operaciones();
            lasOperaciones.EliminarEstados(elIdPermiso);
        }
        public DataTable MostrarResidentes()
        {
            GestorDePermisosDeEstudio.DataAccess.Operaciones lasOperaciones = new DataAccess.Operaciones();
            return lasOperaciones.MostrarResidentes();
        }

        public DataTable MostrarPermisos()
        {
            GestorDePermisosDeEstudio.DataAccess.Operaciones lasOperaciones = new DataAccess.Operaciones();
            return lasOperaciones.MostrarPermisos();
        }
        public DataTable MostrarPermisosDelDia()
        {
            GestorDePermisosDeEstudio.DataAccess.Operaciones lasOperaciones = new DataAccess.Operaciones();
            return lasOperaciones.MostrarPermisosDelDia();
        }
        public DataTable MostrarReportes()
        {
            GestorDePermisosDeEstudio.DataAccess.Operaciones lasOperaciones = new DataAccess.Operaciones();
            return lasOperaciones.MostrarReportes();
        }
        public Boolean EncontrarEstudiante(string elCarnet)
        {
            bool existeElEstudiante = false;
            GestorDePermisosDeEstudio.DataAccess.Operaciones lasOperaciones = new DataAccess.Operaciones();
            var elEstudiante = lasOperaciones.EncontrarEstudiante(elCarnet);

            if (elEstudiante > 0)
            {
                existeElEstudiante = true;
            }
            else
            {
                existeElEstudiante = false;
            }

            return existeElEstudiante;

        }

        public Boolean EncontrarEstudianteExterno(string elCarnet)
        {
            bool existeElEstudiante = false;
            GestorDePermisosDeEstudio.DataAccess.Operaciones lasOperaciones = new DataAccess.Operaciones();
            var elEstudiante = lasOperaciones.EncontrarEstudianteExterno(elCarnet);

            if (elEstudiante > 0)
            {
                existeElEstudiante = true;
            }
            else
            {
                existeElEstudiante = false;
            }

            return existeElEstudiante;

        }

        public Boolean EncontrarUsuario(string elUsuario, string laClave)
        {
            bool existeElUsuario = false;
            GestorDePermisosDeEstudio.DataAccess.Operaciones lasOperaciones = new DataAccess.Operaciones();
            var elUsuarioBuscado = lasOperaciones.EncontrarUsuario(elUsuario, laClave);

            if (elUsuarioBuscado > 0)
            {
                existeElUsuario = true;
            }
            else
            {
                existeElUsuario = false;
            }

            return existeElUsuario;

        }
        public void InsertarReporte(string elReporte, string elCarne)
        {
            string elAsunto = "";
            string elMensaje = "";
            GestorDePermisosDeEstudio.DataAccess.Operaciones lasOperaciones = new DataAccess.Operaciones();
            lasOperaciones.InsertarReporte(elReporte, elCarne);

            elAsunto = "Se ha realizado un reporte";
            elMensaje = "El estudiante con número de carné: " + elCarne + " ha realizado el siguiente reporte: " + elReporte +
                " el día " + DateTime.Now.ToShortDateString() + " a las " + DateTime.Now.ToShortTimeString();

            EnviarCorreo(elMensaje, elAsunto);

        }
        public void InsertarPermiso(string elCarneResidente, string elCarneEstudiante, DateTime laFecha, DateTime laHoraDeEntrada, DateTime laHoraDeSalida)
        {
            DateTime laHoraDelPermiso = DateTime.Now;
            int elIdPermiso = 0;
            string elAsunto = "";
            string elMensaje = "";


            GestorDePermisosDeEstudio.DataAccess.Operaciones lasOperaciones = new DataAccess.Operaciones();

            lasOperaciones.InsertarPermiso(elCarneResidente, elCarneEstudiante, laFecha, laHoraDeEntrada, laHoraDeSalida, laHoraDelPermiso);
            elIdPermiso = EncontrarId(elCarneResidente, elCarneEstudiante, laHoraDelPermiso);
            InsertarPermisoHistorico(elIdPermiso, elCarneResidente, elCarneEstudiante, laFecha, laHoraDeEntrada, laHoraDeSalida);
            InsertarEstado(elIdPermiso, "Aprobado");
    


            elAsunto = "Se ha realizado un permiso";
            elMensaje = "El estudiante con número de carné: " + elCarneEstudiante + " ha solicitado permiso para estudiar con el residente con nú" +
                "mero de carné: " + elCarneResidente + " para el día " + laFecha.ToShortDateString() + ", hora de entrada: " + laHoraDeEntrada.ToShortTimeString() + " y con hora de salida:" +
                " " + laHoraDeSalida.ToShortTimeString();

            EnviarCorreo(elMensaje, elAsunto);

        }
        public void EnviarCorreo(string elMensajeAEnviar, string elAsunto)
        {

            MailMessage elCorreo = new MailMessage();
            SmtpClient elClienteSmtp = new SmtpClient("smtp.gmail.com");


            try
            {
                elCorreo.From = new MailAddress("correo@gmail.com");
                elCorreo.To.Add(new MailAddress("correo@gmail.com"));
                elCorreo.Subject = elAsunto;
                elCorreo.Body = elMensajeAEnviar;
                elCorreo.IsBodyHtml = true;

                elClienteSmtp.Host = "smtp.gmail.com";
                elClienteSmtp.Port = 587;

                elClienteSmtp.UseDefaultCredentials = false;
                elClienteSmtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                elClienteSmtp.Credentials = new NetworkCredential("correo@gmail.com", "contraseña");
                elClienteSmtp.EnableSsl = true;

                elClienteSmtp.Send(elCorreo);


            }
            catch { }

        }
    }
}
