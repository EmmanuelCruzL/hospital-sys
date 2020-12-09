using hospital_sys.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_sys
{
    class cmbController: CoreController
    {
        
        public DataTable getDepartaments()
        {
            
            DataTable tabla = new DataTable();
            try
            {                   
                SqlCommand command = this.prepareCommand("SELECT * FROM departaments");
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

        public DataTable getSpecialties()
        {
            DataTable tabla = new DataTable();
            try
            {                
                SqlCommand command = this.prepareCommand("SELECT * FROM specialties");
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

        public DataTable getCategories()
        {

            DataTable tabla = new DataTable();
            try
            {                
                SqlCommand command = this.prepareCommand("SELECT * FROM categories");                
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


        public  int FindSpeciality(String name)
        {
            int id =-1;
            try
            {
                SqlCommand command = this.prepareCommand("SELECT specialty_id FROM specialties WHERE name = '" + name + "'");                
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read()) {
                    id = dr.GetInt32(0);
                }
                disposeCommand(command);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            return id;
        }

        public int FindDepartament(String name)
        {
            int id = -1;
            try
            {
                String query = "SELECT departament_id FROM departaments WHERE name = '" + name + "'";
                Console.WriteLine(query);
                SqlCommand command = this.prepareCommand(query);                
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read()) {
                    id = dr.GetInt32(0);
                }
                disposeCommand(command);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            return id;
        }

    }
}
