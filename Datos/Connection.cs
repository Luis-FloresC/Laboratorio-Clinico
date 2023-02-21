using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    class Connection
    {
        public SqlConnection ConnectionSQl = new SqlConnection("Server=localhost;Database=master;Trusted_Connection=True;");

        public SqlConnection OpenConnection()
        {
            if (ConnectionSQl.State == ConnectionState.Closed)
            {
                ConnectionSQl.Open();
            }

            return ConnectionSQl;
        }

        public SqlConnection CloseConnection()
        {
            if (ConnectionSQl.State == ConnectionState.Open)
            {
                ConnectionSQl.Close();
            }

            return ConnectionSQl;
        }


    }
}
