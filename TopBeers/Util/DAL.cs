using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace TopBeers.Util
{
    public class DAL
    {
        //private static string server = "localhost";
        //private static string database = "topbeers";
        //private static string user = "root";
        //private static string password = "teibou12";
        //private string connectionString = $"Server={server};Database={database};Uid={user};Password={password}; SslMode = none";

        //private MySqlConnection connection;

        //public DAL()
        //{
        //    connection = new MySqlConnection(connectionString);
        //    connection.Open();
        //}

        ////Executa Select's
        //public DataTable RetDataTable(string sql)
        //{
        //    DataTable datatable = new DataTable();
        //    MySqlCommand command = new MySqlCommand(sql, connection);
        //    MySqlDataAdapter da = new MySqlDataAdapter(command);
        //    da.Fill(datatable);
        //    return datatable;
        //}

        ////Executa Insert's, Update's, Delete's
        //public void ExecutarComandoSql(string sql)
        //{
        //    MySqlCommand command = new MySqlCommand(sql, connection);
        //    command.ExecuteNonQuery();
        //}

    }
}
