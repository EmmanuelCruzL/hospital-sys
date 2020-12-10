using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_sys.Controllers
{
   public  class workBreakController :Controllers.CoreController
    {
        Models.workBreakModel workModel = new Models.workBreakModel();
        public DataTable getWorkBreaks()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection.stringConnection))
                {

                    SqlCommand command = new SqlCommand(null, connection);
                    command.Connection.Open();
                    command.CommandText = "select break_id as Id , patients.patient_name as Nombre,patients.last_name as  Apellido,doc_status Estado_Acta,date_pmi as Fecha_pmi,start_date as Fehca_Inicial,end_date as Fecha_final,situation as Situacion,users.name as Usuario,work_breaks.unit as Unidad   from work_breaks INNER JOIN patients ON work_breaks.patient_id = patients.patient_id INNER JOIN users  ON  work_breaks.user_id = users.user_id ;";
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
        
        public  Boolean CreateWorkBreak(Models.workBreakModel workModel)
        {
            bool register = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection.stringConnection))
                {
                    SqlCommand command = new SqlCommand(null, connection);
                    command.Connection.Open();
                    String sql = "INSERT INTO work_breaks VALUES ('" + workModel.Doc_status + "','" + workModel.Diagnostic + "','" + workModel.Date_pmi + "','" + workModel.Start_date + "','" + workModel.End_date + "','" + workModel.Situation + "','" + workModel.Unit + "','" + workModel.User_id + "','" + workModel.Patient_id + "' )";
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

        public  Boolean EditWorkBreak(Models.workBreakModel workModel)
        {
            bool success = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection.stringConnection))
                {
                    SqlCommand command = new SqlCommand(null, connection);
                    command.Connection.Open();
                    String sql = "UPDATE    work_breaks SET [doc_status] ='" + workModel.Doc_status + "', [diagnostic] = '" + workModel .Diagnostic + "', [date_pmi] ='" + workModel.Date_pmi + "',[start_date]= '" + workModel.Start_date + "' , [end_date] ='" + workModel.End_date + "', [situation] ='" + workModel.Situation + "', [unit] ='" + workModel.Unit + "', [user_id] ='" + workModel.User_id + "', [patient_id] ='" + workModel.Patient_id +  "' WHERE break_id = '" + workModel.Id + "';";
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

        public DataTable SearchWorkBreaks(int  month  )
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection.stringConnection))
                {
                    SqlCommand command = new SqlCommand(null, connection);
                    command.Connection.Open();
                    String sql = "select break_id as Id , patients.patient_name as Nombre,patients.last_name as  Apellido,doc_status Estado_Acta,date_pmi as Fecha_pmi,start_date as Fehca_Inicial,end_date as Fecha_final,situation as Situacion,users.name as Usuario,work_breaks.unit as Unidad   from work_breaks INNER JOIN patients ON work_breaks.patient_id = patients.patient_id INNER JOIN users  ON  work_breaks.user_id = users.user_id WHERE MONTH( date_pmi) =  " + month+" ";
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


        public DataTable searchWorkBreaks(String name, int month)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection.stringConnection))
                {
                    SqlCommand command = new SqlCommand(null, connection);
                    command.Connection.Open();
                    String sql = $"select break_id as Id , patients.patient_name as Nombre,patients.last_name as  Apellido,doc_status Estado_Acta,date_pmi as Fecha_pmi,start_date as Fehca_Inicial,end_date as Fecha_final,situation as Situacion,users.name as Usuario,  work_breaks.unit as Unidad   from work_breaks INNER JOIN patients ON work_breaks.patient_id = patients.patient_id INNER JOIN users  ON  work_breaks.user_id = users.user_id WHERE CONCAT(patients.patient_name,' ',patients.last_name) LIKE  '%{name}%' AND MONTH( date_pmi) = "  + month ;
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
        public Models.workBreakModel searchWorkBreak(int id)
        {
            Models.workBreakModel workModel = new Models.workBreakModel();
            try
            {
                using (SqlConnection connection = new SqlConnection(DBConnection.stringConnection))
                {
                    SqlCommand command = new SqlCommand(null, connection);
                    command.Connection.Open();
                    command.CommandText = "SELECT * FROM  work_breaks WHERE break_id = " + id;
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        
                            workModel.Id = dr.GetInt32(0);
                            workModel.Doc_status = dr.GetString(1);
                            workModel.Diagnostic = dr.GetString(2);
                            workModel.Date_pmi = dr.GetDateTime(3).ToString("yyyy-MM-dd");
                            workModel.Start_date = dr.GetDateTime(4).ToString("yyyy-MM-dd");
                            workModel.End_date = dr.GetDateTime(5).ToString("yyyy-MM-dd");
                            workModel.Situation = dr.GetString(6);
                            workModel.Unit = dr.GetInt32(7);
                            workModel.User_id = dr.GetInt32(8);
                            workModel.Patient_id = dr.GetInt32(9);

                        
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return workModel;
        }
    }
}
