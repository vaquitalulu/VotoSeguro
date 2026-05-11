using CapaEntidad;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class CandidatoDatos
    {
        Conexion cn = new Conexion();

        public List<Candidato> Listar()
        {
            List<Candidato> lista = new List<Candidato>();

            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM Candidato",
                cn.abrirConexion()
            );

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Candidato c = new Candidato();

                c.IdCandidato = Convert.ToInt32(dr["IdCandidato"]);
                c.Nombre = dr["Nombre"].ToString();
                c.Foto = dr["Foto"].ToString();
                c.IdColegio = Convert.ToInt32(dr["IdColegio"]);

                lista.Add(c);
            }

            dr.Close();
            cn.cerrarConexion();

            return lista;
        }
    }
}