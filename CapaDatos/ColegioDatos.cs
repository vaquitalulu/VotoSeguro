using CapaEntidad;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace CapaDatos
{
    public class ColegioDatos
    {
        Conexion cn = new Conexion();

        public List<Colegio> Listar()
        {
            List<Colegio> lista = new List<Colegio>();

            SqlCommand cmd = new SqlCommand(
                "SELECT IdColegio, Nombre, Direccion, Nivel FROM Colegio",
                cn.abrirConexion()
            );

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new Colegio
                {
                    IdColegio = Convert.ToInt32(dr["IdColegio"]),
                    Nombre = dr["Nombre"].ToString(),
                    Direccion = dr["Direccion"].ToString(),
                    Nivel = dr["Nivel"].ToString()
                });
            }

            dr.Close();
            cn.cerrarConexion();

            return lista;
        }
    }
}
