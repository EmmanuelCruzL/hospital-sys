using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace hospital_sys.Controllers
{
    public class CoreController
    {

        public void disposeCommand(SqlCommand command) {
            try {
                command.Connection.Close();                
            }
            catch (Exception d) {
            }
        }

        public SqlCommand prepareCommand(String sql)
        {            
            try
            {
                SqlConnection connection = new SqlConnection(DBConnection.stringConnection);
                SqlCommand command = new SqlCommand(null, connection);
                command.Connection.Open();
                command.CommandText = sql;
                return command;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return null;
        }
    }
}
