using CapaEntidad;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class VotoDatos
    {
        Conexion cn = new Conexion();

        public bool Registrar(Voto v)
        {
            SqlCommand verificar = new SqlCommand(
                "SELECT YaVoto FROM Estudiante WHERE IdEstudiante=@IdEstudiante",
                cn.abrirConexion()
            );

            verificar.Parameters.AddWithValue("@IdEstudiante", v.IdEstudiante);

            bool yaVoto = Convert.ToBoolean(verificar.ExecuteScalar());

            if (yaVoto == true)
            {
                cn.cerrarConexion();
                return false;
            }

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Voto(IdEstudiante, IdCandidato) VALUES(@IdEstudiante, @IdCandidato)",
                cn.abrirConexion()
            );

            cmd.Parameters.AddWithValue("@IdEstudiante", v.IdEstudiante);
            cmd.Parameters.AddWithValue("@IdCandidato", v.IdCandidato);

            cmd.ExecuteNonQuery();

            SqlCommand actualizar = new SqlCommand(
                "UPDATE Estudiante SET YaVoto = 1 WHERE IdEstudiante=@IdEstudiante",
                cn.abrirConexion()
            );

            actualizar.Parameters.AddWithValue("@IdEstudiante", v.IdEstudiante);

            actualizar.ExecuteNonQuery();

            cn.cerrarConexion();

            return true;
        }
    }
}