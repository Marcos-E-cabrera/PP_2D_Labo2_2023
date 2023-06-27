using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Biblioteca_Carniceria
{
    public class CD_Productos
    {
        private static CD_Conexion conexion = new CD_Conexion();
        private static SqlDataReader reader;
        private static SqlCommand command = new SqlCommand();


        public static List<Producto> CreacionListaProductos()
        {
            List<Producto> productos = new List<Producto>();

            command.Connection = conexion.AbrirConexion();
            command.CommandText = "SELECT * FROM PRODUCTO";

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                productos.Add(new Producto(reader["CORTE"].ToString(),
                                    float.Parse(reader["PRECIO"].ToString()),
                                    int.Parse(reader["STOCK"].ToString()),
                                    int.Parse(reader["ID_TIPO"].ToString()),
                                    int.Parse(reader["ID"].ToString())
                                    ));
            }
           
            command.Connection = conexion.CerrarConexion();

            return productos;
        }

        public static void Created(string corte, float precio, int stock, string tipo )
        {
            command.Connection = conexion.AbrirConexion();
            command.CommandText = "INSERT INTO PRODUCTO VALUES (@corte, @precio, @stock, @tipo)";

            command.Parameters.AddWithValue("@corte",corte);
            command.Parameters.AddWithValue("@precio", precio);
            command.Parameters.AddWithValue("@stock", stock);

            eTipo tipoAux = (eTipo)Enum.Parse(typeof(eTipo), tipo);

            command.Parameters.AddWithValue("@tipo", tipoAux);

            // Ejecutar el comando SQL
            command.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public static void Update(string corte, float precio, int stock, string tipo, int id)
        {
            command.Connection = conexion.AbrirConexion();
            command.CommandText = "UPDATE PRODUCTO SET corte = @c, precio = @p, stock = @s, id_tipo = @t WHERE ID = @i";

            command.Parameters.AddWithValue("@i", id);
            command.Parameters.AddWithValue("@c", corte);
            command.Parameters.AddWithValue("@p", precio);
            command.Parameters.AddWithValue("@s", stock);

            eTipo tipoAux = (eTipo)Enum.Parse(typeof(eTipo), tipo);

            command.Parameters.AddWithValue("@t", tipoAux);

            command.ExecuteNonQuery();
            conexion.CerrarConexion();

        }

        public  static void Delate(int id)
        {
            command.Connection = conexion.AbrirConexion();

            command.CommandText = "DELETE FROM PRODUCTO WHERE id = @id";
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

    }
}
