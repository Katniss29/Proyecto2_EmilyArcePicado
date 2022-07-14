using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;

namespace capaNegocio
{
    public class NEGOCIO
    {

        //Method to query all items
        public static DataTable consultarTodosElementos(String table, String[] datos)
        {
            String campo = "SELECT ";

            for (int i = 0; i < datos.Length; i++)
            {
                campo += "\"" + datos[i] + "\"";
                if (i != datos.Length - 1)
                {
                    campo += ",";
                }
            }
            campo += " FROM \"" + table + "\"";
            String query = campo;
            DataTable resultado = CONEXION.consultarUnDato(query);
            return resultado;
        }
    }
}
