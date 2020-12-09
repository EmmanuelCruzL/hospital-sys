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
    public partial class PanelGeneral : Form
    {

        User user;
        UserController userC;

        public PanelGeneral(User currentUser)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.user = currentUser;
            this.userC = new UserController();
            this.UserPanel.Text = Global.userTypes[this.user.User_type];
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Descansos_Medicos frm = new Descansos_Medicos(0,this.user);
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Descansos_Medicos frm = new Descansos_Medicos(3, this.user);
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Descansos_Medicos frm = new Descansos_Medicos(1, this.user);
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Descansos_Medicos frm = new Descansos_Medicos(2, this.user);
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Descansos_Medicos frm = new Descansos_Medicos(5, this.user);
            frm.Show();
        }

        private void PanelGeneral_Load(object sender, EventArgs e)
        {
            this.mainActions.Location = new Point(this.Width/2- this.mainActions.Width/2, 250);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
