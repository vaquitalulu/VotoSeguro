using CapaEntidad;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class ResultadoDatos
    {
        Conexion cn = new Conexion();

        public List<Resultado> ListarResultados()
        {
            List<Resultado> lista = new List<Resultado>();

            SqlCommand cmd = new SqlCommand(
                @"SELECT C.Nombre,
                  COUNT(V.IdVoto) AS TotalVotos
                  FROM Voto V
                  INNER JOIN Candidato C
                  ON V.IdCandidato = C.IdCandidato
                  GROUP BY C.Nombre",
                cn.abrirConexion()
            );

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Resultado r = new Resultado();

                r.Nombre = dr["Nombre"].ToString();
                r.TotalVotos = Convert.ToInt32(dr["TotalVotos"]);

                lista.Add(r);
            }

            dr.Close();
            cn.cerrarConexion();

            return lista;
        }
    }
}