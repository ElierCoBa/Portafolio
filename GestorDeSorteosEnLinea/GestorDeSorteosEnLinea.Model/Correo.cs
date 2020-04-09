using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace GestorDeSorteosEnLinea.Model
{
	public class Correo
	{

		public string MensajeAEnviar { get; set; }
		public string Asunto { get; set; }
		public string SmtpClient { get; set; }
		public string CorreoRemitente { get; set; }
		public string CorreoReceptor { get; set; }
		public string Contrasena { get; set; }
		

		public Correo( string elMensajeAEnviar, string elAsunto)
		{
			CorreoRemitente = "proyectolenguajes2019@gmail.com";
			
			Asunto = elAsunto;
			SmtpClient = "smtp.gmail.com";
			Contrasena = "elProyecto19.";
			MensajeAEnviar = elMensajeAEnviar;



		}

	}
	
}
