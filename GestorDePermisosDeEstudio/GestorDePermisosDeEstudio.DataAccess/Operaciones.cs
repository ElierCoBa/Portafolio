using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace GestorDePermisosDeEstudio.DataAccess
{
    public class Operaciones
    {

        public int EncontrarEstudiante(string elCarnet)
        {
            int elEstudiante = 0;
            var laBaseDeDatos = new Context();
            laBaseDeDatos.AbrirConexion();

            SqlCommand losComandosSQL = new SqlCommand();
            losComandosSQL.CommandText = "SP_LoguearEstudiante";
            losComandosSQL.Connection = laBaseDeDatos.laConexionSQL;
            losComandosSQL.CommandType = System.Data.CommandType.StoredProcedure;

            losComandosSQL.Parameters.Add(new SqlParameter("@elId", elCarnet));
          
            SqlParameter elLogueo = new SqlParameter("@elLogueo", 0);
            elLogueo.Direction = System.Data.ParameterDirection.Output;
            losComandosSQL.Parameters.Add(elLogueo);

            losComandosSQL.ExecuteNonQuery();
            laBaseDeDatos.CerrarConexion();

            elEstudiante = Int32.Parse(losComandosSQL.Parameters["@elLogueo"].Value.ToString());
            
            return elEstudiante;
        }

        public int EncontrarEstudianteExterno(string elCarnet)
        {
            int elEstudiante = 0;
            var laBaseDeDatos = new Context();
            laBaseDeDatos.AbrirConexion();

            SqlCommand losComandosSQL = new SqlCommand();
            losComandosSQL.CommandText = "SP_LoguearEstudianteExterno";
            losComandosSQL.Connection = laBaseDeDatos.laConexionSQL;
            losComandosSQL.CommandType = System.Data.CommandType.StoredProcedure;

            losComandosSQL.Parameters.Add(new SqlParameter("@elId", elCarnet));

            SqlParameter elLogueo = new SqlParameter("@elLogueo", 0);
            elLogueo.Direction = System.Data.ParameterDirection.Output;
            losComandosSQL.Parameters.Add(elLogueo);

            losComandosSQL.ExecuteNonQuery();
            laBaseDeDatos.CerrarConexion();

            elEstudiante = Int32.Parse(losComandosSQL.Parameters["@elLogueo"].Value.ToString());

            return elEstudiante;
        }

        public int EncontrarPermisos(string elCarne)
        {
            int elEstudiante = 0;
            var laBaseDeDatos = new Context();
            laBaseDeDatos.AbrirConexion();

            SqlCommand losComandosSQL = new SqlCommand();
            losComandosSQL.CommandText = "SP_EncontrarPermisos";
            losComandosSQL.Connection = laBaseDeDatos.laConexionSQL;
            losComandosSQL.CommandType = System.Data.CommandType.StoredProcedure;

            losComandosSQL.Parameters.Add(new SqlParameter("@elId", elCarne));

            SqlParameter elLogueo = new SqlParameter("@elLogueo", 0);
            elLogueo.Direction = System.Data.ParameterDirection.Output;
            losComandosSQL.Parameters.Add(elLogueo);

            losComandosSQL.ExecuteNonQuery();
            laBaseDeDatos.CerrarConexion();

            elEstudiante = Int32.Parse(losComandosSQL.Parameters["@elLogueo"].Value.ToString());

            return elEstudiante;
        }

        public int EncontrarUsuario(string elUsuario,string laClave)
        {
            int elUsuarioBuscado = 0;
            var laBaseDeDatos = new Context();
            laBaseDeDatos.AbrirConexion();

            SqlCommand losComandosSQL = new SqlCommand();
            losComandosSQL.CommandText = "SP_LoguearUsuario";
            losComandosSQL.Connection = laBaseDeDatos.laConexionSQL;
            losComandosSQL.CommandType = System.Data.CommandType.StoredProcedure;

            losComandosSQL.Parameters.Add(new SqlParameter("@elUsuario", elUsuario));
            losComandosSQL.Parameters.Add(new SqlParameter("@laClave", laClave));

            SqlParameter elLogueo = new SqlParameter("@elLogueo", 0);
            elLogueo.Direction = System.Data.ParameterDirection.Output;
            losComandosSQL.Parameters.Add(elLogueo);

            losComandosSQL.ExecuteNonQuery();
            laBaseDeDatos.CerrarConexion();

            elUsuarioBuscado = Int32.Parse(losComandosSQL.Parameters["@elLogueo"].Value.ToString());

            return elUsuarioBuscado;
        }

        public int EncontrarId(string elCarneResidente, string elCarneEstudiante, DateTime laHora)
        {
           
                int elUsuarioBuscado = 0;
                var laBaseDeDatos = new Context();
                laBaseDeDatos.AbrirConexion();

                SqlCommand losComandosSQL = new SqlCommand();
                losComandosSQL.CommandText = "SP_EncontrarId";
                losComandosSQL.Connection = laBaseDeDatos.laConexionSQL;
                losComandosSQL.CommandType = System.Data.CommandType.StoredProcedure;

                losComandosSQL.Parameters.Add(new SqlParameter("@elIdResidente", elCarneResidente));
                losComandosSQL.Parameters.Add(new SqlParameter("@elIdEstudiante", elCarneEstudiante));
                losComandosSQL.Parameters.Add(new SqlParameter("@laHora", laHora));
                 
                SqlParameter elLogueo = new SqlParameter("@elLogueo", 0);
                elLogueo.Direction = System.Data.ParameterDirection.Output;
                losComandosSQL.Parameters.Add(elLogueo);
            
                losComandosSQL.ExecuteNonQuery();
                laBaseDeDatos.CerrarConexion();

                elUsuarioBuscado = int.Parse(losComandosSQL.Parameters["@elLogueo"].SqlValue.ToString());
              
         
                return elUsuarioBuscado;
     
        }
  
        public int EncontrarIdAEliminar(string elCarneResidente)
        {

            int elUsuarioBuscado = 0;
            var laBaseDeDatos = new Context();
            laBaseDeDatos.AbrirConexion();

            SqlCommand losComandosSQL = new SqlCommand();
            losComandosSQL.CommandText = "SP_EncontrarIdAEliminar";
            losComandosSQL.Connection = laBaseDeDatos.laConexionSQL;
            losComandosSQL.CommandType = System.Data.CommandType.StoredProcedure;

            losComandosSQL.Parameters.Add(new SqlParameter("@elIdResidente", elCarneResidente));

            SqlParameter elLogueo = new SqlParameter("@elLogueo", 0);
            elLogueo.Direction = System.Data.ParameterDirection.Output;
            losComandosSQL.Parameters.Add(elLogueo);

            losComandosSQL.ExecuteNonQuery();
            laBaseDeDatos.CerrarConexion();

            elUsuarioBuscado = int.Parse(losComandosSQL.Parameters["@elLogueo"].SqlValue.ToString());


            return elUsuarioBuscado;

        }

        public void InsertarReporte(string elReporte, string elCarne)
        {
   
            var laBaseDeDatos = new Context();
            laBaseDeDatos.AbrirConexion();

            SqlCommand losComandosSQL = new SqlCommand();
            losComandosSQL.CommandText = "SP_InsertarReporte";
            losComandosSQL.Connection = laBaseDeDatos.laConexionSQL;
            losComandosSQL.CommandType = System.Data.CommandType.StoredProcedure;

            losComandosSQL.Parameters.Add(new SqlParameter("@laFecha", DateTime.Now));
            losComandosSQL.Parameters.Add(new SqlParameter("@elReporte", elReporte));
            losComandosSQL.Parameters.Add(new SqlParameter("@elIdReportante", elCarne));

            losComandosSQL.ExecuteNonQuery();
            laBaseDeDatos.CerrarConexion();

        }

        public void InsertarCuarto(string elPabellon,string elCuarto, string elCarne)
        {

            var laBaseDeDatos = new Context();
            laBaseDeDatos.AbrirConexion();

            SqlCommand losComandosSQL = new SqlCommand();
            losComandosSQL.CommandText = "SP_InsertarCuarto";
            losComandosSQL.Connection = laBaseDeDatos.laConexionSQL;
            losComandosSQL.CommandType = System.Data.CommandType.StoredProcedure;

            losComandosSQL.Parameters.Add(new SqlParameter("@elPabellon", elPabellon));
            losComandosSQL.Parameters.Add(new SqlParameter("@elCuarto", elCuarto));
            losComandosSQL.Parameters.Add(new SqlParameter("@elIdResidente", elCarne));

            losComandosSQL.ExecuteNonQuery();
            laBaseDeDatos.CerrarConexion();

        }
        public void ActualizarCuarto(string elPabellon, string elCuarto, string elCarne)
        {

            var laBaseDeDatos = new Context();
            laBaseDeDatos.AbrirConexion();

            SqlCommand losComandosSQL = new SqlCommand();
            losComandosSQL.CommandText = "SP_ActualizarCuarto";
            losComandosSQL.Connection = laBaseDeDatos.laConexionSQL;
            losComandosSQL.CommandType = System.Data.CommandType.StoredProcedure;

            losComandosSQL.Parameters.Add(new SqlParameter("@elIdResidente", elCarne));
            losComandosSQL.Parameters.Add(new SqlParameter("@elPabellon", elPabellon));
            losComandosSQL.Parameters.Add(new SqlParameter("@elCuarto", elCuarto));
          

            losComandosSQL.ExecuteNonQuery();
            laBaseDeDatos.CerrarConexion();

        }
        public void InsertarResidente(string elCarne, string elApellido1, string elApellido2, string elNombre1, string elNombre2)
        {

            var laBaseDeDatos = new Context();
            laBaseDeDatos.AbrirConexion();

            SqlCommand losComandosSQL = new SqlCommand();
            losComandosSQL.CommandText = "SP_InsertarResidente";
            losComandosSQL.Connection = laBaseDeDatos.laConexionSQL;
            losComandosSQL.CommandType = System.Data.CommandType.StoredProcedure;

            losComandosSQL.Parameters.Add(new SqlParameter("@elId", elCarne));
            losComandosSQL.Parameters.Add(new SqlParameter("@elApellido1", elApellido1));
            losComandosSQL.Parameters.Add(new SqlParameter("@elApellido2", elApellido2));
            losComandosSQL.Parameters.Add(new SqlParameter("@elNombre1", elNombre1));
            losComandosSQL.Parameters.Add(new SqlParameter("@elNombre2", elNombre2));


            losComandosSQL.ExecuteNonQuery();
            laBaseDeDatos.CerrarConexion();

        }

        public void ActualizarResidente(string elCarne, string elApellido1, string elApellido2, string elNombre1, string elNombre2)
        {

            var laBaseDeDatos = new Context();
            laBaseDeDatos.AbrirConexion();

            SqlCommand losComandosSQL = new SqlCommand();
            losComandosSQL.CommandText = "SP_ActualizarResidente";
            losComandosSQL.Connection = laBaseDeDatos.laConexionSQL;
            losComandosSQL.CommandType = System.Data.CommandType.StoredProcedure;

            losComandosSQL.Parameters.Add(new SqlParameter("@elIdResidente", elCarne));
            losComandosSQL.Parameters.Add(new SqlParameter("@elApellido1", elApellido1));
            losComandosSQL.Parameters.Add(new SqlParameter("@elApellido2", elApellido2));
            losComandosSQL.Parameters.Add(new SqlParameter("@elNombre1", elNombre1));
            losComandosSQL.Parameters.Add(new SqlParameter("@elNombre2", elNombre2));


            losComandosSQL.ExecuteNonQuery();
            laBaseDeDatos.CerrarConexion();

        }

        public void InsertarEstudiante(string elCarne, string elApellido1, string elApellido2, string elNombre1, string elNombre2)
        {

            var laBaseDeDatos = new Context();
            laBaseDeDatos.AbrirConexion();

            SqlCommand losComandosSQL = new SqlCommand();
            losComandosSQL.CommandText = "SP_InsertarEstudiante";
            losComandosSQL.Connection = laBaseDeDatos.laConexionSQL;
            losComandosSQL.CommandType = System.Data.CommandType.StoredProcedure;

            losComandosSQL.Parameters.Add(new SqlParameter("@elId", elCarne));
            losComandosSQL.Parameters.Add(new SqlParameter("@elApellido1", elApellido1));
            losComandosSQL.Parameters.Add(new SqlParameter("@elApellido2", elApellido2));
            losComandosSQL.Parameters.Add(new SqlParameter("@elNombre1", elNombre1));
            losComandosSQL.Parameters.Add(new SqlParameter("@elNombre2", elNombre2));


            losComandosSQL.ExecuteNonQuery();
            laBaseDeDatos.CerrarConexion();

        }

        public void InsertarPermiso(string elCarneResidente, string elCarneEstudiante, DateTime laFecha, DateTime laHoraDeEntrada, DateTime laHoraDeSalida, DateTime laHoraDelPermiso)
        {

            var laBaseDeDatos = new Context();
            laBaseDeDatos.AbrirConexion();

            SqlCommand losComandosSQL = new SqlCommand();
            losComandosSQL.CommandText = "SP_InsertarPermiso";
            losComandosSQL.Connection = laBaseDeDatos.laConexionSQL;
            losComandosSQL.CommandType = System.Data.CommandType.StoredProcedure;

            losComandosSQL.Parameters.Add(new SqlParameter("@elIdResidente", elCarneResidente));
            losComandosSQL.Parameters.Add(new SqlParameter("@elIdEstudiante", elCarneEstudiante));
            losComandosSQL.Parameters.Add(new SqlParameter("@laFecha", laFecha));
            losComandosSQL.Parameters.Add(new SqlParameter("@laHora", laHoraDelPermiso));
            losComandosSQL.Parameters.Add(new SqlParameter("@laHoraDeEntrada", laHoraDeEntrada));
            losComandosSQL.Parameters.Add(new SqlParameter("@laHoraDeSalida", laHoraDeSalida));


            losComandosSQL.ExecuteNonQuery();
            laBaseDeDatos.CerrarConexion();

        }


        public void InsertarPermisoHistorico(int elId,string elCarneResidente, string elCarneEstudiante, DateTime laFecha, DateTime laHoraDeEntrada, DateTime laHoraDeSalida)
        {

            var laBaseDeDatos = new Context();
            laBaseDeDatos.AbrirConexion();

            SqlCommand losComandosSQL = new SqlCommand();
            losComandosSQL.CommandText = "SP_InsertarPermisoHistorico";
            losComandosSQL.Connection = laBaseDeDatos.laConexionSQL;
            losComandosSQL.CommandType = System.Data.CommandType.StoredProcedure;
            losComandosSQL.Parameters.Add(new SqlParameter("@elId", elId));
            losComandosSQL.Parameters.Add(new SqlParameter("@elIdResidente", elCarneResidente));
            losComandosSQL.Parameters.Add(new SqlParameter("@elIdEstudiante", elCarneEstudiante));
            losComandosSQL.Parameters.Add(new SqlParameter("@laFecha", laFecha));
            losComandosSQL.Parameters.Add(new SqlParameter("@laHora", DateTime.Now));
            losComandosSQL.Parameters.Add(new SqlParameter("@laHoraDeEntrada", laHoraDeEntrada));
            losComandosSQL.Parameters.Add(new SqlParameter("@laHoraDeSalida", laHoraDeSalida));
        

            losComandosSQL.ExecuteNonQuery();
            laBaseDeDatos.CerrarConexion();

        }

        public void InsertarEstado(int elIdPermiso,string elEstado)
        {

            var laBaseDeDatos = new Context();
            laBaseDeDatos.AbrirConexion();

            SqlCommand losComandosSQL = new SqlCommand();
            losComandosSQL.CommandText = "SP_InsertarEstado";
            losComandosSQL.Connection = laBaseDeDatos.laConexionSQL;
            losComandosSQL.CommandType = System.Data.CommandType.StoredProcedure;

            losComandosSQL.Parameters.Add(new SqlParameter("@elIdPermiso", elIdPermiso));
            losComandosSQL.Parameters.Add(new SqlParameter("@elEstado", elEstado));

            losComandosSQL.ExecuteNonQuery();
            laBaseDeDatos.CerrarConexion();

        }

       
        public void EliminarResidente(string elCarne)
        {
            try
            {
                var laBaseDeDatos = new Context();
                laBaseDeDatos.AbrirConexion();

                SqlCommand losComandosSQL = new SqlCommand();
                losComandosSQL.CommandText = "SP_EliminarResidente";
                losComandosSQL.Connection = laBaseDeDatos.laConexionSQL;
                losComandosSQL.CommandType = System.Data.CommandType.StoredProcedure;

                losComandosSQL.Parameters.Add(new SqlParameter("@elIdResidente", elCarne));

                losComandosSQL.ExecuteNonQuery();
                laBaseDeDatos.CerrarConexion();
            }catch(Exception e)
            { Console.WriteLine(e.ToString()); }

        }
        public void EliminarPermisos(int elIdPermiso)
        {

            var laBaseDeDatos = new Context();
            laBaseDeDatos.AbrirConexion();

            SqlCommand losComandosSQL = new SqlCommand();
            losComandosSQL.CommandText = "SP_EliminarPermisos";
            losComandosSQL.Connection = laBaseDeDatos.laConexionSQL;
            losComandosSQL.CommandType = System.Data.CommandType.StoredProcedure;

            losComandosSQL.Parameters.Add(new SqlParameter("@elIdResidente", elIdPermiso));

            losComandosSQL.ExecuteNonQuery();
            laBaseDeDatos.CerrarConexion();

        }

        public void EliminarEstados(int elIdPermiso)
        {

            var laBaseDeDatos = new Context();
            laBaseDeDatos.AbrirConexion();

            SqlCommand losComandosSQL = new SqlCommand();
            losComandosSQL.CommandText = "SP_EliminarEstados";
            losComandosSQL.Connection = laBaseDeDatos.laConexionSQL;
            losComandosSQL.CommandType = System.Data.CommandType.StoredProcedure;

            losComandosSQL.Parameters.Add(new SqlParameter("@elIdPermiso", elIdPermiso));

            losComandosSQL.ExecuteNonQuery();
            laBaseDeDatos.CerrarConexion();

        }
        public void EliminarCuarto(string elCarne)
        {

            var laBaseDeDatos = new Context();
            laBaseDeDatos.AbrirConexion();

            SqlCommand losComandosSQL = new SqlCommand();
            losComandosSQL.CommandText = "SP_EliminarCuarto";
            losComandosSQL.Connection = laBaseDeDatos.laConexionSQL;
            losComandosSQL.CommandType = System.Data.CommandType.StoredProcedure;

            losComandosSQL.Parameters.Add(new SqlParameter("@elIdResidente", elCarne));

            losComandosSQL.ExecuteNonQuery();
            laBaseDeDatos.CerrarConexion();

        }
        public DataTable MostrarResidentes()
        {
            DataTable laTablaDeResidentes = new DataTable();
            SqlDataReader elLector;
            var laBaseDeDatos = new Context();
            laBaseDeDatos.AbrirConexion();

            SqlCommand losComandosSQL = new SqlCommand();
            losComandosSQL.CommandText = "SP_SeleccionarResidentes";
            losComandosSQL.Connection = laBaseDeDatos.laConexionSQL;
            losComandosSQL.CommandType = System.Data.CommandType.StoredProcedure;
            elLector = losComandosSQL.ExecuteReader();
            laTablaDeResidentes.Load(elLector);
            elLector.Close();

            laBaseDeDatos.CerrarConexion();

            return laTablaDeResidentes;
        }

        public DataTable MostrarResidenteEspecifico(string elCarne)
        {
            DataTable laTablaDeResidentes = new DataTable();
            SqlDataReader elLector;
            var laBaseDeDatos = new Context();
            laBaseDeDatos.AbrirConexion();

            SqlCommand losComandosSQL = new SqlCommand();
            losComandosSQL.CommandText = "SP_SeleccionarResidenteEspecifico";
            losComandosSQL.Connection = laBaseDeDatos.laConexionSQL;
            losComandosSQL.CommandType = System.Data.CommandType.StoredProcedure;
            losComandosSQL.Parameters.Add(new SqlParameter("@elIdResidente", elCarne));
            elLector = losComandosSQL.ExecuteReader();
            laTablaDeResidentes.Load(elLector);
            elLector.Close();

            laBaseDeDatos.CerrarConexion();

            return laTablaDeResidentes;
        }
        public DataTable MostrarPermisos()
        {
            DataTable laTablaDeResidentes = new DataTable();
            SqlDataReader elLector;
            var laBaseDeDatos = new Context();
            laBaseDeDatos.AbrirConexion();

            SqlCommand losComandosSQL = new SqlCommand();
            losComandosSQL.CommandText = "SP_SeleccionarPermisos";
            losComandosSQL.Connection = laBaseDeDatos.laConexionSQL;
            losComandosSQL.CommandType = System.Data.CommandType.StoredProcedure;

            elLector = losComandosSQL.ExecuteReader();
            laTablaDeResidentes.Load(elLector);
            elLector.Close();

            laBaseDeDatos.CerrarConexion();

            return laTablaDeResidentes;
        }

        public DataTable MostrarPermisosDelDia()
        {
            DataTable laTablaDeResidentes = new DataTable();
            SqlDataReader elLector;
            var laBaseDeDatos = new Context();
            laBaseDeDatos.AbrirConexion();

            SqlCommand losComandosSQL = new SqlCommand();
            losComandosSQL.CommandText = "SP_SeleccionarPermisosDelDia";
            losComandosSQL.Connection = laBaseDeDatos.laConexionSQL;
            losComandosSQL.CommandType = System.Data.CommandType.StoredProcedure;
            losComandosSQL.Parameters.Add(new SqlParameter("@laFecha", DateTime.Now.ToShortDateString()));
            elLector = losComandosSQL.ExecuteReader();
            laTablaDeResidentes.Load(elLector);
            elLector.Close();

            laBaseDeDatos.CerrarConexion();

            return laTablaDeResidentes;
        }

        public DataTable MostrarReportes()
        {
            DataTable laTablaDeResidentes = new DataTable();
            SqlDataReader elLector;
            var laBaseDeDatos = new Context();
            laBaseDeDatos.AbrirConexion();

            SqlCommand losComandosSQL = new SqlCommand();
            losComandosSQL.CommandText = "SP_SeleccionarReportes";
            losComandosSQL.Connection = laBaseDeDatos.laConexionSQL;
            losComandosSQL.CommandType = System.Data.CommandType.StoredProcedure;
            elLector = losComandosSQL.ExecuteReader();
            laTablaDeResidentes.Load(elLector);
            elLector.Close();

            laBaseDeDatos.CerrarConexion();

            return laTablaDeResidentes;
        }
    }
}
