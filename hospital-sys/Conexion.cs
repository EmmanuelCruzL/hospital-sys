using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace hospital_sys
{
  public  class Conexion
    {

        public  Boolean Connect()
        {
            bool isConnect = false;
            try
            {
                SqlConnection conexion = new SqlConnection("server=DESKTOP-2E6H87O\\SQLEXPRESS ; database=hospital_sys ; integrated security = true");
                conexion.Open();
                Console.WriteLine("Conexion exitosa.");
                isConnect = true;
            }
            catch {
                Console.WriteLine("Error en la conexion");
            }
            return isConnect;
        }

        
    }
}
