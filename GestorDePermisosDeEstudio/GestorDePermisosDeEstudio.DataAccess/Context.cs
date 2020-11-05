using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestorDePermisosDeEstudio.DataAccess
{
    public class Context
    {
        public string laCadenaDeConexion = "Data Source=DESKTOP\\SQLEXPRESS;Initial Catalog=ResidenciasSedeGuanacaste;Integrated Security=True";
        public SqlConnection laConexionSQL = new SqlConnection();

        public Context()
        {
            laConexionSQL.ConnectionString = laCadenaDeConexion;
        }
        public void AbrirConexion()
        {
            try
            {
                laConexionSQL.Open();
            }
            catch
            {
                Console.WriteLine("Conexion fallida");
            }
        }

        public void CerrarConexion()
        {
            try
            {
                laConexionSQL.Close();
            }
            catch
            {
                Console.WriteLine("Conexion fallida");
            }
        }
    }
}
