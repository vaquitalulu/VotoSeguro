using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        private SqlConnection cn = new SqlConnection(
           "Server=DESKTOP-4P8GC3O\\SQLEXPRESS;Database=VotoSeguro;Trusted_Connection=True;TrustServerCertificate=True;"
        );

        public SqlConnection abrirConexion()
        {
            if (cn.State == System.Data.ConnectionState.Closed)
            {
                cn.Open();
            }

            return cn;
        }

        public SqlConnection cerrarConexion()
        {
            if (cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }

            return cn;
        }
    }
}
