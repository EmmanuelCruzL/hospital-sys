using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_sys
{
  public  class LoginModel
    {
        private int  id;
        private String name;
        private String last_name;
        private String password;
        private int status;
        private int tipo;

       

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public string Password { get => password; set => password = value; }
        public int Status { get => status; set => status = value; }
        public int Tipo { get => tipo; set => tipo = value; }
    }
}
