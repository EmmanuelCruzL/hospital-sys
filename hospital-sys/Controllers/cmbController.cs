using hospital_sys.Controllers;
using hospital_sys.Models;
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


        public Category findCategoryByName(String  name)
        {
            try
            {
                Console.WriteLine("SELECT * FROM categories where name = " + name);
                SqlCommand command = this.prepareCommand("SELECT * FROM categories where name = '" + name+"'");
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Category(
                        reader.GetInt32(0),
                        reader.GetString(1)
                        );
                }
                disposeCommand(command);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return null;
        }

        public Category findCategoryById(int id)
        {
            try
            {
                Console.WriteLine("SELECT * FROM categories where category_id = " + id);
                SqlCommand command = this.prepareCommand("SELECT * FROM categories where category_id = "+id);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) {
                    return new Category(
                        reader.GetInt32(0),
                        reader.GetString(1)
                        );
                }
                disposeCommand(command);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return null;
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

        public Specialty findSpecialtyById(int id)
        {            
            try
            {
                Console.WriteLine("SELECT * FROM specialties WHERE specialty_id = " + id + "");
                SqlCommand command = this.prepareCommand("SELECT * FROM specialties WHERE specialty_id = " + id + "");
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    return new Specialty(
                            dr.GetInt32(0),
                            dr.GetString(1)
                        );
                }
                disposeCommand(command);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            return null;
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
