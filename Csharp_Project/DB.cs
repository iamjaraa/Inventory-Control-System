using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Csharp_Project
{
    class DB
    {
        SqlConnection connection;

        public DB()
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SHOLABASH\Music\Csharp_inventory_management_system\Csharp_Project\Csharp_Project\MY_DB.mdf;Integrated Security=True");
        }

        public void openConnection()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public DataTable getData(string procedureName, SqlParameter[] procedureParams)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = procedureName;
            command.Connection = connection;
            if (procedureParams != null)
            {
                for (int i = 0; i < procedureParams.Length; i++)
                {
                    command.Parameters.Add(procedureParams[i]);
                }
            }

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public void setData(string procedureName, SqlParameter[] procedureParams)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = procedureName;
            command.Connection = connection;
            if (procedureParams != null)
            {
                command.Parameters.AddRange(procedureParams);
            }

            command.ExecuteNonQuery();
        }

    }
}
