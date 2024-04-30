using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapFormu.Utilities
{
    internal class SingletonDbConnection
    {
        private static SingletonDbConnection instance; //singleton instance
        private static readonly object lockObject = new object();
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=TechCareer; Integrated Security=True;";
        private SqlConnection connection;
        public SqlConnection Connection => connection;
        private SingletonDbConnection()
        {
            connection = new SqlConnection(connectionString);
        }
        public static SingletonDbConnection GetInstance()
        {
            lock (lockObject) //birden fazla thread aynı anda bu metoda erişemesin. guvenli singleton kullanimi
            {
                if (instance == null)
                {
                    instance = new SingletonDbConnection();
                }
                return instance;
            }
        }
        public void OpenConnection()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }
        public void CloseConnection()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }
    }
}
