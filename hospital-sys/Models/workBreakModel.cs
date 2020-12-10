using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_sys.Models
{
  public   class workBreakModel
    {
        private int id;
        private String doc_status;
        private String diagnostic;
        private String date_pmi;
        private String start_date;
        private String end_date;
        private String situation;
        private int unit;
        private int user_id;
        private int patient_id;

        public int Id { get => id; set => id = value; }
        public string Doc_status { get => doc_status; set => doc_status = value; }
        public string Diagnostic { get => diagnostic; set => diagnostic = value; }
        public string Date_pmi { get => date_pmi; set => date_pmi = value; }
        public string Start_date { get => start_date; set => start_date = value; }
        public string End_date { get => end_date; set => end_date = value; }
        public string Situation { get => situation; set => situation = value; }
        public int Unit { get => unit; set => unit = value; }
        public int User_id { get => user_id; set => user_id = value; }
        public int Patient_id { get => patient_id; set => patient_id = value; }
    }
}
