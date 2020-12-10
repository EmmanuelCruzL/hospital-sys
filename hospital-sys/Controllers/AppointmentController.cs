using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using hospital_sys.Models;

namespace hospital_sys.Controllers
{
    public class AppointmentController: CoreController
    {

        public DataTable getAppointmentsByPatientId(int patientId, int userId)
        {

            DataTable tabla = new DataTable();
            try
            {
                SqlCommand command = this.prepareCommand("SELECT * FROM appointments where patient_id = "+patientId+" and user_id = "+userId);
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(tabla);
                disposeCommand(command);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            return tabla;
        }

        public bool saveAppointment(Appointment a)
        {

            
            try
            {

                String var = $"INSERT INTO appointments VALUES ( {a.IsWorkBreak} , '{a.MedicalHistory}', '{a.ClinicalExamination}', " +
                             $"'{a.CurrentDisease}', "+
                             $"'{a.DiagnosticSupport}', " +
                             $"'{a.Diagnosis}', " +
                             $"'{a.Etilogy}', " +
                             $"'{a.Evolution}', " +
                             $"'{a.Secual}', " +
                             $"'{a.Treatment}', " +
                             $"'{a.Forcecat}', " +
                             $"'{a.MagnitudeDependecny}', " +
                             $"'{a.DregreeDpendency}', " +
                             $"'{a.CommentsServiceDisease}', " +
                             $"'{a.AproximateTime}', " +
                             $"'{a.WorkRelize}', " +
                             $"'{a.Guarnizion}', " +
                             $"'{a.DateMedicalMeeting.ToString("yyyy-MM-dd HH:mm:ss:fff")}', " +
                             $"'{a.NextEvaluationDate.ToString("yyyy-MM-dd HH:mm:ss:fff")}', " +
                             $"'{a.Conclusion}', " +
                             $"{a.PatientId}, " +
                             $"{a.UserId} )";
                Console.WriteLine(var);
                SqlCommand command = this.prepareCommand(var);
                command.ExecuteNonQuery();                
                disposeCommand(command);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            return false;
        }

    }
}
