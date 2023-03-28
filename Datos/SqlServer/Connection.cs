using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Datos
{
    public abstract class Connection
    {
        //public SqlConnection ConnectionSQl = new SqlConnection("Server=localhost;Database=Laboratorio_clinico;Trusted_Connection=True;");

        //Variable donde contendra la cadena de conexión donde solo esta habilitada para solo lectura
        private readonly string connectionString;
        //Contructor de la Clase de Conexión 
        public Connection()
        {
           connectionString = "Server=localhost;Database=Laboratorio_clinico;Trusted_Connection=True;";
         
        }

        //Función para obtener la conexión
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }


    }
}
