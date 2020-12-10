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

        public void log(User user)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection.stringConnection))
                {
                    DateTime localDate = DateTime.Now;
                    SqlCommand command = new SqlCommand($"INSERT INTO sessions values ({user.Id}, '{localDate.ToString("dd/MM/yyyy HH:mm")}',1);", connection);
                    command.Connection.Open();
                    command.Prepare();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public User login(User user)
        {                        
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection.stringConnection))
                {                    
                    SqlCommand command = new SqlCommand("SELECT * FROM users  WHERE name  = '" + user.Name + "'AND user_password = '" + user.Password + "' ", connection);
                    command.Connection.Open();
                    SqlDataReader reader =  command.ExecuteReader();
                    if (reader.Read()) {
                        return new User(                        
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetInt32(4),
                            reader.GetInt32(5),
                            reader.GetInt32(6),
                            reader.GetInt32(7)
                        );
                    }
                    
                }                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());                
            }
            return null; 
        }  
    }
}
