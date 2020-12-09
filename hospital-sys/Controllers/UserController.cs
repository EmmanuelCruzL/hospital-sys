using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;
 
namespace hospital_sys
{
    public class UserController: Controllers.CoreController
    {
            

        public DataTable getUsers()
        {            
            DataTable tabla = new DataTable();
            try
            {
                SqlCommand command = this.prepareCommand("SELECT user_id as ID  ,users.name as Nombre  ,last_name as Apellido,user_password as Contraseña, status as Estado ,user_type as Tipo,specialties.name as Especialidad,departaments.name as Departamento FROM users INNER JOIN specialties ON users.specialty_id = specialties.specialty_id INNER JOIN departaments ON users.departament_id = departaments.departament_id");                
                SqlDataReader dr = command.ExecuteReader();
                tabla.Load(dr);
                disposeCommand(command);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                
            }
            return tabla ;
        } 

        public Boolean createUser(User user)
        {
            bool register = false;
            try
            {

                SqlCommand command = this.prepareCommand("INSERT INTO users VALUES ('" + user.Name + "','" + user.Last_name + "','" + user.Password + "','" + user.Status + "','" + user.User_type + "','" + user.Specialty + "','" + user.Departament + "')");
                command.Prepare();
                command.ExecuteNonQuery();
                disposeCommand(command);
                register = true;  
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return register;
        }
        public  bool  editUser(User user)
        {
            bool success = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection.stringConnection))
                {
                    SqlCommand command = new SqlCommand(null, connection);
                    command.Connection.Open();
                    command.CommandText = "UPDATE    users SET name ='" + user.Name + "',last_name = '" + user.Last_name + "',user_password ='" + user.Password + "',status = " + user.Status + ", user_type =" + user.User_type + ", specialty_id =" + user.Specialty + ", departament_id =" + user.Departament + "WHERE user_id = " + user.Id + "";
                    command.Prepare();
                    command.ExecuteNonQuery();
                    success = true;
                }
                
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return success;
        }

        public  bool delUser(User user)
        {
            bool success = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection.stringConnection))
                {
                    SqlCommand command = new SqlCommand(null, connection);
                    command.Connection.Open();
                    command.CommandText = "DELETE   FROM  users  WHERE user_id =" + user.Id;
                    command.Prepare();
                    command.ExecuteNonQuery();
                    success = true;
                }
                
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return success;
        }

        public User searchUser(int id)
        {
            User user= new User();
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection.stringConnection))
                {
                    SqlCommand command = new SqlCommand(null, connection);
                    command.Connection.Open();
                    command.CommandText = "SELECT * FROM  users WHERE user_id = " + id;
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.NextResult())
                    {
                        user.Id = id;
                        user.Name = dr.GetString(2);
                        user.Last_name = dr.GetString(3);
                        user.Password = dr.GetString(4);
                        user.Status = dr.GetInt32(5);
                        user.User_type = dr.GetInt32(6);
                        user.Specialty = dr.GetInt32(7);
                        user.Departament = dr.GetInt32(8);

                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return user;
        }

    }
}
