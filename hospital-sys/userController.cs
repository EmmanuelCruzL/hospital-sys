using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace hospital_sys
{
    class userController
    {
        Conexion con = new Conexion();

        public List<userModel> getUsers()
        {
            try
            {
                SqlCommand command = new SqlCommand(null, con.Connect());
                command.CommandText = "SELECT * FROM users";

            }
            catch
            {

            }
            return null;
        } 

    }
}
