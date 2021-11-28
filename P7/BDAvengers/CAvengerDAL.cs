using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BDAvengers
{
    class CAvengerDAL
    {
        private string strConexion;
        public CAvengerDAL()
        {
            // Obtener la cadena de conexión: elija la adecuada para su instalación
            //strConexion = @"Data Source=.\sqlexpress;" +
            // @"Initial Catalog=bd_famosos; Integrated Security=True";
            strConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
            @"AttachDbFilename=|DataDirectory|\bd_avengers.mdf; " +
            @"Integrated Security=True";
            // Si no es válido MSSQLLocalDB pruebe con v11.0
        }

        public ColCAvengers ObtenerFilasAvengers()
        {
            try
            {
                using (SqlConnection Conexion = new SqlConnection(strConexion))
                {
                    SqlCommand OrdenSql =
                    new SqlCommand("stproObtenerFilasAvengers", Conexion);
                    OrdenSql.CommandType = CommandType.StoredProcedure;
                    // Crear una colección para todos los avengers
                    ColCAvengers colAvengers = new ColCAvengers();
                    // Abrir la base de datos
                    Conexion.Open();
                    SqlDataReader lector = OrdenSql.ExecuteReader();
                    while (lector.Read())
                    {
                        CAvengerBO fila = new CAvengerBO((int)lector["ID"],
                        (string)lector["alias"], (string)lector["nombre"],
                        (DateTime)lector["cumple"], (string)lector["imagen"]);
                        colAvengers.Add(fila);
                    }
                    return colAvengers;
                }
            }
            catch (SqlException err)
            {
                throw new ApplicationException("Error SELECT avenger");
            }
        }
        public void ActualizarAvengers(CAvengerBO bo)
        {
            try
            {
                using (SqlConnection Conexion = new SqlConnection(strConexion))
                {
                    SqlCommand OrdenSql = new SqlCommand("stproActualizarAvengers", Conexion);
                    OrdenSql.CommandType = CommandType.StoredProcedure;
                    // Crear una colección para todos los avengers
                    OrdenSql.Parameters.AddWithValue("@ID",bo.Id);
                    OrdenSql.Parameters.AddWithValue("@alias", bo.Alias);
                    OrdenSql.Parameters.AddWithValue("@nombre", bo.Nombre);
                    OrdenSql.Parameters.AddWithValue("@cumple", bo.Cumple);
                    OrdenSql.Parameters.AddWithValue("@imagen", bo.Imagen);

                    // Abrir la base de datos
                    Conexion.Open();
                    OrdenSql.ExecuteNonQuery();
                }
            }
            catch (SqlException err)
            {
                throw new ApplicationException("Error INSERT avenger");
            }
        }
    }
}