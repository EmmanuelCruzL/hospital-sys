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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Name = txtUser.Text,
                Password = txtPwd.Text
            };
            try
            {
                loginController login = new loginController();
                user = login.login(user);
                if (user!=null)
                {                    
                    PanelGeneral frmGeneral = new PanelGeneral(user);
                    this.Hide();
                    frmGeneral.Show();
                }
                else
                {
                    MessageBox.Show("Usuario/Contraseña incorrecta.\nVuelve a intentarlo.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
