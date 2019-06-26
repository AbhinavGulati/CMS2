using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.MY_Sql_Gateway
{
    public class MYSQLGATWAY
    {

        private string _connectionString;

        public SqlConnection CreateConnection()
        {
            return new SqlConnection("data source=DESKTOP-5D77V30; database=MasterDistrict; integrated security=SSPI"); 
        }

        public MYSQLGATWAY(string connectionString)
        {
            this._connectionString = "data source=DESKTOP-5D77V30; database=MasterDistrict; integrated security=SSPI";
        }

        public MYSQLGATWAY()
        {
        }

        public DataTable ExecuteProcedure(string procedure_name, List<KeyValuePair<string, string>> param_list)
        {
            SqlConnection _conn = CreateConnection();
            _conn.Open();
            SqlCommand cmd = new SqlCommand("", _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = procedure_name;

            if (param_list != null)
            {
                for (int i = 0; i < param_list.Count; i++)
                {
                    cmd.Parameters.AddWithValue(param_list[i].Key, param_list[i].Value);
                }
            }

            SqlDataAdapter _da = new SqlDataAdapter(cmd);
            DataSet _ds = new DataSet();

            _conn.Close();

            _da.Fill(_ds, "ResponeData");

            return _ds.Tables["ResponeData"];
        }

       

        public DataSet ExecuteProcedureWithDataSet(string procedure_name, List<KeyValuePair<string, string>> param_list)
        {
            SqlConnection _conn = CreateConnection();
            _conn.Open();
            SqlCommand cmd = new SqlCommand("", _conn);
            //cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = procedure_name;
            if (param_list != null)
            {
                for (int i = 0; i < param_list.Count; i++)
                {
                    cmd.Parameters.AddWithValue(param_list[i].Key, param_list[i].Value);
                }
            }

            SqlDataAdapter _da = new SqlDataAdapter(cmd);
            DataSet _ds = new DataSet();

            _da.Fill(_ds, "ResponeData");

            _conn.Close();

            return _ds;
        }

        internal DataSet ExecuteProcedureWithDataSet(string v, Func<IActionResult> registrationColony)
        {
            throw new NotImplementedException();
        }

        public DataTable ExecuteQuery(string query)
        {
            SqlConnection _conn = CreateConnection();
            _conn.Open();

            SqlCommand cmd = new SqlCommand(query, _conn);

            SqlDataAdapter _da = new SqlDataAdapter(cmd);
            DataSet _ds = new DataSet();

            _da.Fill(_ds, "ResponeData");

            _conn.Close();

            return _ds.Tables["ResponeData"];
        }
    }
}
