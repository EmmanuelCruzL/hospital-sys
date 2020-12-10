using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hospital_sys.Controllers;
using System.Data;
using System.Data.SqlClient;
using hospital_sys.Models;

namespace hospital_sys.Controllers
{
    class Report : CoreController
    {

        public List<Series> getDoctoresActivity(int year)
        {

            List<Series> series = new List<Series>();
            try
            {
                SqlCommand command = this.prepareCommand("SELECT* FROM sessions as s inner join users as u on s.user_id = u.user_id where u.user_type = 1");                
                SqlDataReader dr = command.ExecuteReader();
                series = new List<Series>();
                while (dr.Read())
                {
                    series.Add(new Series
                    {
                        Serie1 = Decimal.Parse(dr.GetInt32(0).ToString()),
                        Serie2 = Decimal.Parse(dr.GetInt32(10).ToString()),
                        mes = dr.GetDateTime(1).ToString("yyyy-MM-dd")
                    });
                }

                disposeCommand(command);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }

            return series;
        }

        public List<Series> getUserActivity(int year) {

            List<Series> series = new List<Series>();
            try
            {
                SqlCommand command = this.prepareCommand("SELECT* FROM sessions as s inner join users as u on s.user_id = u.user_id where u.user_type = 0");
                SqlDataReader dr = command.ExecuteReader();
                series = new List<Series>();
                while (dr.Read()) {
                    series.Add(new Series { 
                        Serie1 = Decimal.Parse(dr.GetInt32(0).ToString()),
                        Serie2 = Decimal.Parse(dr.GetInt32(10).ToString()),
                        mes = dr.GetDateTime(1).ToString("yyyy-MM-dd")
                    });
                }

                disposeCommand(command);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }

            return series;
        }
    }
}
