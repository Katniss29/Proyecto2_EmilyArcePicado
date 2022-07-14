using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace capaDatos
{
    public class CONEXION
    {
        //Database connection
        public static NpgsqlConnection conexion = new NpgsqlConnection("Server = localhost; User Id = postgres; Password = Admin12345; DataBase = RECURSOSHUMANOS");

        //Method to connect to the database
        public static void conectarPostgresSQL()
        {
            conexion.Open();
            Console.WriteLine("Conexión a la base de datos");

        }

        //Method to disconnect the database
        public static void desconectarPostgresSQL()
        {
            conexion.Close();
            Console.WriteLine("Desconexion de la base de datos");
        }

        //Method to query data from the database
        public static DataTable consultarUnDato(String query)
        {
            try
            {
                NpgsqlCommand conector = new NpgsqlCommand(query, conexion);
                NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
                DataTable table = new DataTable();
                datos.Fill(table);
                desconectarPostgresSQL();
                return table;
            }
            catch (Exception)
            {
                return null;
            }

        }

    }



}

