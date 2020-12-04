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

        public SqlConnection Connect()
        {
            SqlConnection conexion = null;
            
            try
            {
                conexion = new SqlConnection("server=DESKTOP-2E6H87O\\SQLEXPRESS ; database=hospital_sys ; integrated security = true");
                conexion.Open();
                Console.WriteLine("Conexion exitosa.");
                
            }
            catch {
                Console.WriteLine("Error en la conexion");
            }
            return conexion;
        }

        
    }
}
