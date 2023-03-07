using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public abstract class Connection
    {
        //public SqlConnection ConnectionSQl = new SqlConnection("Server=localhost;Database=Laboratorio_clinico;Trusted_Connection=True;");

        private readonly string connectionString;
        public Connection()
        {
            connectionString = "Server=localhost;Database=Laboratorio_clinico;Trusted_Connection=True;";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }


    }
}
