using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Carniceria
{
    public class CD_Cliente
    {
        private static CD_Conexion conexion = new CD_Conexion();
        private static SqlDataReader reader;
        private static SqlCommand command = new SqlCommand();
        private static List<Cliente> usuarios = new List<Cliente>();

        public static List<Cliente> CreacionListaUsuario()
        {

            command.Connection = conexion.AbrirConexion();
            command.CommandText = "SELECT * FROM Usuario_Cliente";
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                usuarios.Add(new Cliente(reader["Nombre"].ToString(), reader["Apellido"].ToString(), 0, reader["Email"].ToString(), reader["Password"].ToString()));

            }
            command.Connection = conexion.CerrarConexion();

            return usuarios;
        }

        public static void Created(string nombre, string apellido, string email, string password)
        {
            command.Connection = conexion.AbrirConexion();
           
            command.CommandText = "INSERT INTO Usuario_Cliente VALUES (@nombre, @apellido, @email, @password)";

            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@apellido", apellido);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@password", password);

            command.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public static void Read()
        {
            command.Connection = conexion.AbrirConexion();
            command.CommandText = "SELECT TOP 1 * FROM Usuario_Cliente ORDER BY id DESC";
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                usuarios.Add(new Cliente(reader["Nombre"].ToString(),
                                             reader["Apellido"].ToString(), 0,
                                             reader["Email"].ToString(),
                                             reader["Password"].ToString()));
            }
        }
    }
}
