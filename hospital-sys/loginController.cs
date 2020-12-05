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

        public userModel login(userModel user)
        {
           
            try
            {
                SqlCommand command = new SqlCommand(null, con.Connect());
                command.CommandText = "SELECT * FROM users  WHERE last_nmae  = '"+user.Name+"'AND user_password ='"+user.Password+"'";
                SqlDataReader dr = command.ExecuteReader();

                
                    while (dr.NextResult())
                    {
                        user.Id = (dr.GetInt32(1));
                        user.Name = (dr.GetString(2));
                        user.Last_name = (dr.GetString(3));
                        user.Status = (dr.GetInt32(5));
                        user.User_type = (dr.GetInt32(6));
                        user.Specialty = (dr.GetInt32(7));
                        user.Departament = (dr.GetInt32(8));

                    }
                    return user;
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return   null;
            }
            
        }
    }
}
