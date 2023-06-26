using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace Biblioteca_Carniceria
{
    public class ConexionSql
    {
        // instancio la Connection le paso la ruta de BBDD y el nombre.
        public static SqlConnection connection;
        public static SqlCommand command = new SqlCommand();
        public static SqlDataReader reader;

        static ConexionSql()
        {
            connection = new SqlConnection(@"Data Source=.; Database=Carniceria; Trusted_Connection=True;");

            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
        }

    }
}
