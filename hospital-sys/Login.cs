using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_sys
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userModel user = new userModel();
            
            user.Name = txtUser.Text;
            user.Password = txtPwd.Text;
            try
            {
                loginController login = new loginController();
                
                if (login.login(user)!=null)
                {
                    MessageBox.Show("Conexion Exitosa");
                    PanelGeneral frmGeneral = new PanelGeneral(login.login(user));
                    this.Hide();
                    frmGeneral.Show();

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString()); 
                MessageBox.Show("Error usuario y contraseña");
            }
        }
    }
}
