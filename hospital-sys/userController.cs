using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;
 
namespace hospital_sys
{
    class userController
    {
        Conexion con = new Conexion();

        public DataTable getUsers()
        {
            List<userModel> users = new List<userModel>();
            DataTable tabla = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(null, con.Connect());
                command.CommandText = "SELECT user_id as ID  ,users.name as Nombre  ,last_nmae as Apellido,user_password as Contraseña, status as Estado ,user_type as Tipo,specialties.name as Epecialidad,departaments.name as Departamento FROM users INNER JOIN specialties ON users.specialty_id = specialties.specialty_id INNER JOIN departaments ON users.departament_id = departaments.departament_id";
                SqlDataReader dr = command.ExecuteReader();
                tabla.Load(dr);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                
            }
            return tabla ;
        } 

        public Boolean createUser(userModel user)
        {
            bool register = false;
            try
            {
                SqlCommand command = new SqlCommand(null, con.Connect());
                command.CommandText = "INSERT INTO users VALUES ('"+user.Name+"','"+user.Last_name+"','"+user.Password+"',"+user.Status+",'"+user.User_type+"','"+user.Specialty+"','"+user.Departament+"')";
                command.Prepare();
                command.ExecuteNonQuery();
                register = true;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return register;
        }
        public  bool  editUser(userModel user)
        {
            bool success = false;
            try
            {
                SqlCommand command = new SqlCommand(null, con.Connect());
                command.CommandText = "UPDATE    users SET(name ='" + user.Name + "',last_nmae = '" + user.Last_name + "',user_password ='" + user.Password + "',status = " + user.Status + ", user_type =" + user.User_type + ", specialty_id =" + user.Specialty + ", departament_id =" + user.Departament + "WHERE user_id = "+user.Id+")";
                command.Prepare();
                command.ExecuteNonQuery();
                success = true;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return success;
        }

        public  bool delUser(userModel user)
        {
            bool success = false;
            try
            {
                SqlCommand command = new SqlCommand(null, con.Connect());
                command.CommandText = "DELETE   FROM  users  WHERE user_id =" + user.Id;
                command.Prepare();
                command.ExecuteNonQuery();
                success = true;                
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return success;
        }
    
    }
}
