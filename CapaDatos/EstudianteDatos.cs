using CapaEntidad;
using Microsoft.Data.SqlClient;
using System;

namespace CapaDatos
{
    public class EstudianteDatos
    {
        Conexion cn = new Conexion();

        public Estudiante Login(string dni, string clave)
        {
            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM Estudiante WHERE Dni=@Dni AND Clave=@Clave",
                cn.abrirConexion()
            );

            cmd.Parameters.AddWithValue("@Dni", dni);
            cmd.Parameters.AddWithValue("@Clave", clave);

            SqlDataReader dr = cmd.ExecuteReader();

            Estudiante est = new Estudiante();

            if (dr.Read())
            {
                est.IdEstudiante = Convert.ToInt32(dr["IdEstudiante"]);
                est.Nombre = dr["Nombre"].ToString();
                est.Dni = dr["Dni"].ToString();
                est.Clave = dr["Clave"].ToString();
                est.YaVoto = Convert.ToBoolean(dr["YaVoto"]);
                est.IdColegio = Convert.ToInt32(dr["IdColegio"]);
            }

            dr.Close();
            cn.cerrarConexion();

            return est;
        }
    }
}
