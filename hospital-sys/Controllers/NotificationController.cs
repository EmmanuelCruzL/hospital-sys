using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hospital_sys.Controllers;
using hospital_sys.Models;
using System.Data;
using System.Data.SqlClient;
namespace hospital_sys.Controllers
{
    public class NotificationController: CoreController
    {


        public DataTable getNotification()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection.stringConnection))
                {

                    SqlCommand command = new SqlCommand(null, connection);
                    command.Connection.Open();
                    command.CommandText = "select patient_id as id, patient_name as Nombre, last_name as Apellidos, CASE gender WHEN 1 THEN 'Femenino' WHEN 0 THEN 'Masculino' END AS Genero, dni as DNI , grade as Grado , sit_admin as Sit_admin, state_pml as State_Pml, arma as Arma, guarnicion as Guarnicion , categories.name as Categoria, COALESCE (NULLIF (created, ''), SYSDATETIME()) AS Registrado, unit as Unidad FROM patients INNER JOIN categories ON patients.category_id = categories.category_id;";
                    SqlDataReader dr = command.ExecuteReader();
                    tabla.Load(dr);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            return tabla;
        }

    }
}
