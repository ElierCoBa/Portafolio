using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GestorDeSorteosEnLinea.SI
{
	// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiciosDeCorreo" en el código y en el archivo de configuración a la vez.
	[ServiceContract]
	public interface IServiciosDeCorreo
	{
		[OperationContract]
		bool EnviarCorreoNormal(string elEmailReceptor,string elNombre, string elMensajeAEnviar, string elAsunto, string laContrasena);
		[OperationContract]
		Model.AspNetUsers ConsultarUnUsuarioPorNombre(string nombre);

	}
}
