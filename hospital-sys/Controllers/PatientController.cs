using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_sys
{
    class PatientController
    {
        
        public DataTable getPatients()
        {            
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection.stringConnection))
                {
                    
                    SqlCommand command = new SqlCommand(null,connection);
                    command.Connection.Open();                    
                    command.CommandText = "select patient_id as id, patient_name as Nombre, last_name as Apellidos, CASE gender WHEN 1 THEN 'Femenino' WHEN 0 THEN 'Masculino' END AS Genero, dni as DNI , grade as Grado , sit_admin as Sit_admin, state_pml as State_Pml, arma as Arma, guarnicion as Guarnicion , categories.name as Categoria, COALESCE (NULLIF (created, ''), SYSDATETIME()) AS Registrado,unit as Unidad FROM patients INNER JOIN categories ON patients.category_id = categories.category_id;";
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
        public Boolean createUser(PatientModel patient)
        {
            bool register = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection.stringConnection)) {
                    SqlCommand command = new SqlCommand(null, connection);
                    command.Connection.Open();
                    String sql = "INSERT INTO patients VALUES ('" + patient.Name + "','" + patient.Last_name + "'," + patient.GenderId + ",'" + patient.Dni + "','" + patient.Grade + "','" + patient.Sit_admin + "','" + patient.State_pml + "','" + patient.Arma + "','" + patient.Guarnicion + "'," + patient.Category +", '"+patient.Created+"'"+  ")";
                    Console.WriteLine(sql);
                    command.CommandText = sql;
                    command.Prepare();
                    command.ExecuteNonQuery();
                    register = true;
                }
                    
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return register;

        }
        public bool editUser(PatientModel patient)
        {
            bool success = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection.stringConnection))
                {
                    SqlCommand command = new SqlCommand(null, connection);
                    command.Connection.Open();
                    String sql = "UPDATE    patients SET patient_name ='" + patient.Name + "', last_name = '" + patient.Last_name + "', gender =" + patient.GenderId + ",dni= '" + patient.Dni + "' , grade ='" + patient.Grade + "', sit_admin ='" + patient.Sit_admin + "', state_pml ='" + patient.State_pml + "', arma ='" + patient.Arma + "', guarnicion='" + patient.Guarnicion + "', category_id =" + patient.Category + " WHERE patient_id = " + patient.Id + ";";
                    Console.WriteLine(sql);
                    command.CommandText = sql;
                    command.Prepare();
                    command.ExecuteNonQuery();
                    success = true;
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return success;
        }
        public bool delUser(PatientModel patient)
        {
            bool success = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection.stringConnection))
                {
                    SqlCommand command = new SqlCommand(null, connection);
                    command.Connection.Open();
                    command.CommandText = "DELETE   FROM  patients  WHERE patient_id =" + patient.Id;
                    command.Prepare();
                    command.ExecuteNonQuery();
                    success = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return success;
        }       
        public DataTable searchPatients(String name)
        {
            
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection.stringConnection)) {
                    SqlCommand command = new SqlCommand(null, connection);
                    command.Connection.Open();
                    String sql = "select patient_id as id, patient_name as Nombre, last_name as Apellidos, CASE gender WHEN 1 THEN 'Femenino' WHEN 0 THEN 'Masculino' END AS Genero, dni as DNI , grade as Grado , sit_admin as Sit_admin, state_pml as State_Pml, arma as Arma, guarnicion as Guarnicion , categories.name as Categoria, COALESCE (NULLIF (created, ''), SYSDATETIME()) AS Registrado FROM patients INNER JOIN categories ON patients.category_id = categories.category_id WHERE CONCAT(patient_name,' ',last_name) LIKE '%"+name+"%';";                    
                    Console.WriteLine(sql);
                    command.CommandText = sql;
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

        public PatientModel searchPatient(int id)
        {
            PatientModel patient = new PatientModel();
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection.stringConnection))
                {
                    SqlCommand command = new SqlCommand(null, connection);
                    command.Connection.Open();
                    command.CommandText = "SELECT * FROM  patients WHERE patient_id = " + id;
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        
                            patient.Id = dr.GetInt32(0);
                            patient.Name = dr.GetString(1);
                            patient.Last_name = dr.GetString(2);
                            patient.Gender = dr.GetString(3);
                            patient.Dni = dr.GetString(4);
                            patient.Grade = dr.GetString(5);
                            patient.Sit_admin = dr.GetString(6);
                            patient.State_pml = dr.GetString(7);

                        
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return patient;
        }
    }
}
