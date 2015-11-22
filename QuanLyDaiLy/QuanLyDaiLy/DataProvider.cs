using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using System.Collections;

namespace QuanLyDaiLy
{
    public class DataProvider
    {
        protected static string _connectionString;

        protected OleDbConnection connection;
        protected OleDbDataAdapter adapter;
        protected OleDbCommand command;


        public static string ConnectionString
        {
            get
            {
                return _connectionString;
            }
            set
            {
                _connectionString = value;
            }
        }

        public void connect()
        {
            connection = new OleDbConnection(ConnectionString);
            connection.Open();
        }

        public void disconnect()
        {
            connection.Close();
        }

        public IDataReader executeQuery(string sqlString)
        {
            command = new OleDbCommand(sqlString, connection);
            return command.ExecuteReader();
        }

        //public DataTable executeQuery(string sqlString)
        //{
        //    DataSet ds = new DataSet();
        //    adapter = new OleDbDataAdapter(sqlString, connection);
        //    adapter.Fill(ds);
        //    return ds.Tables[0];
        //}

        public void executeNonQuery(string sqlString)
        {
            command = new OleDbCommand(sqlString, connection);
            command.ExecuteNonQuery();
        }

        public object executeScalar(string sqlString)
        {
            command = new OleDbCommand(sqlString, connection);
            return command.ExecuteScalar();
        }

        protected ArrayList ConvertDataSetToArrayList(DataSet dataset)
        {
            ArrayList arr = new ArrayList();
            DataTable dt = dataset.Tables[0];
            int i, n = dt.Rows.Count;
            for (i = 0; i < n; i++)
            {
                object obj = GetDataFromDataRow(dt, i);
                arr.Add(obj);

            }
            return arr;
        }

        protected virtual object GetDataFromDataRow(DataTable dt, int i)
        {
            return null;
        }
    }
}
