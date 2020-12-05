using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_sys
{
    class cmbController
    {
        Conexion con = new Conexion();
        public DataTable getDepartaments()
        {
            
            DataTable tabla = new DataTable();
            try
            {   
                String query  = "SELECT * FROM departaments";
                SqlCommand command = new SqlCommand(query, con.Connect());
                
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(tabla);

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
                String query = "SELECT * FROM specialties";
                SqlCommand command = new SqlCommand(query, con.Connect());

                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(tabla);

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
                String query = "SELECT * FROM categories";
                SqlCommand command = new SqlCommand(query, con.Connect());

                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(tabla);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            return tabla;
        }


    }
}
