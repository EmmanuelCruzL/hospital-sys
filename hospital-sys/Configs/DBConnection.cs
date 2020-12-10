using System;
using System.Data.SqlClient;
namespace hospital_sys
{
  public  class DBConnection
    {
        //DESKTOP-2E6H87O\SQLEXPRESS
        private static DBConnection _instance = null;
        private static readonly object _syncObject = new Object();
        public static String stringConnection = @"Data Source=DESKTOP-2E6H87O\SQLEXPRESS; Initial Catalog=hospital_sys; integrated security = true;";
        private static SqlConnection conexion = null;
        public static DBConnection Instance
        {
            get
            {
                if (_instance == null) {
                    lock (_syncObject) {
                        if (_instance == null) {
                            _instance = new DBConnection();
                        }
                    }
                }

                return _instance;
            }
        }

        public SqlConnection getConnection()
        {                       
            try
            {
                if (conexion == null || conexion.State == System.Data.ConnectionState.Closed) {
                    conexion = new SqlConnection(stringConnection);
                    Console.WriteLine("Get Connection.");                    
                }                
            }
            catch(Exception e) {
                Console.WriteLine("Connection error: ");
                Console.WriteLine(e.Message);
            }
            return conexion;
        }

        
    }
}
