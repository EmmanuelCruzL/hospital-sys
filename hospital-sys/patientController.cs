using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_sys
{
    class patientController
    {
        Conexion con = new Conexion();

        public DataTable getPatients()
        {
            List<userModel> users = new List<userModel>();
            DataTable tabla = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(null, con.Connect());
                command.CommandText = "select * from  patients";
                SqlDataReader dr = command.ExecuteReader();
                tabla.Load(dr);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            return tabla;
        }

        public Boolean createUser(patientModel patient)
        {
            bool register = false;
            try
            {
                SqlCommand command = new SqlCommand(null, con.Connect());
                command.CommandText = "INSERT INTO patients VALUES ('" + patient.Name + "','" + patient.Last_name + "','" + patient.Gender + "'," + patient.Dni + ",'" + patient.Grade + "','" + patient.Sit_admin + "','" + patient.State_pml + "','" + patient.Arma + "','" + patient.Guarnicion + "'," + patient.Category + ")";
                command.Prepare();
                command.ExecuteNonQuery();
                register = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return register;

        }

        public bool editUser(patientModel patient)
        {
            bool success = false;
            try
            {
                SqlCommand command = new SqlCommand(null, con.Connect());
                command.CommandText = "UPDATE    patients SET(patient_name ='" + patient.Name + "',last_name = '" + patient.Last_name + "',gender ='" + patient.Gender + "',dni= " + patient.Dni + ", grade =" + patient.Grade + ", sit_admin =" + patient.Sit_admin+ ", state_pml =" + patient.State_pml+ ", arma =" + patient.Arma+ ", guarnicion=" + patient.Guarnicion + ", cetegory_id =" + patient.Category + " WHERE patient_id = " + patient.Id + ")";
                command.Prepare();
                command.ExecuteNonQuery();
                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return success;
        }
        public bool delUser(patientModel patient)
        {
            bool success = false;
            try
            {
                SqlCommand command = new SqlCommand(null, con.Connect());
                command.CommandText = "DELETE   FROM  patients  WHERE patient_id =" +patient.Id;
                command.Prepare();
                command.ExecuteNonQuery();
                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return success;
        }

        public patientModel  searchPatient(int id)
        {
            patientModel patient = new patientModel();
            try
            {
                SqlCommand command = new SqlCommand(null, con.Connect());
                command.CommandText = "select * from  patients WHERE patient_id = "+id;
                SqlDataReader dr = command.ExecuteReader();
                while (dr.NextResult())
                {
                    patient.Id = dr.GetInt32(1);
                    patient.Name = dr.GetString(2);
                    patient.Last_name = dr.GetString(3);
                    patient.Gender = dr.GetString(4);
                    patient.Dni = dr.GetString(5);
                    patient.Grade = dr.GetString(6);
                    patient.Sit_admin = dr.GetString(7);
                    patient.State_pml = dr.GetString(8);
                    patient.Arma = dr.GetString(9);
                    patient.Guarnicion = dr.GetString(10);
                    patient.Category = dr.GetInt32(11);
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return patient;
        }
    }
}
