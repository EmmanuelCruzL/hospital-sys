using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_sys
{
   public class loginController
    {
        Conexion con = new Conexion();

        public bool login(userModel user)
        {
            int id = 0;
            bool login = false;
            try
            {
                SqlCommand command = new SqlCommand(null, con.Connect());
                command.CommandText = "SELECT * FROM users  WHERE last_name  = '"+user.Name+"'AND user_password = '"+user.Password+"' ";
                SqlDataReader dr = command.ExecuteReader();

                if (dr.Read())
                {
                    login = true;
                } 
                
                    
                
                
                    
                    
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                
            }
            return login; 
        }  
    }
}
