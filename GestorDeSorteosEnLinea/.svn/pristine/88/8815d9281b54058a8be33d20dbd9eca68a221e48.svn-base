using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using GestorDeSorteosEnLinea.Model;

namespace GestorDeSorteosEnLinea.SI
{
	// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiciosDeCorreo" en el código, en svc y en el archivo de configuración a la vez.
	// NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiciosDeCorreo.svc o ServiciosDeCorreo.svc.cs en el Explorador de soluciones e inicie la depuración.
	public class ServiciosDeCorreo : IServiciosDeCorreo
	{
		public Boolean EnviarCorreoNormal(string elEmailReceptor, string elNombre, string elMensajeAEnviar, string elAsunto, string laContrasena) {

			GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones;
			elGestorDeOperaciones = new Business.GestorDeOperaciones();
			
			GestorDeSorteosEnLinea.Model.Correo elCorreoAEnviar = new Model.Correo( elMensajeAEnviar, elAsunto);
			bool resultadoDeEnvio = elGestorDeOperaciones.EnviarCorreoNormal(elEmailReceptor, elNombre, elCorreoAEnviar.MensajeAEnviar, elCorreoAEnviar.Asunto, elCorreoAEnviar.Contrasena);
			return resultadoDeEnvio;
		}

		public Model.AspNetUsers ConsultarUnUsuarioPorNombre(string nombre)
		{
			GestorDeSorteosEnLinea.Business.GestorDeOperaciones elGestorDeOperaciones = new Business.GestorDeOperaciones();
			return elGestorDeOperaciones.ConsultarUnUsuarioPorNombre(nombre);



		}

	}
}
