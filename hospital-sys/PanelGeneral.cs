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
        userModel user = new userModel();
        public PanelGeneral(userModel user)
        {
            InitializeComponent();
            this.UserPanel.Text = user.Name;
            this.user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Descansos_Medicos frm = new Descansos_Medicos(user);
            frm.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Descansos_Medicos frm = new Descansos_Medicos(user);
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Descansos_Medicos frm = new Descansos_Medicos(user);
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Descansos_Medicos frm = new Descansos_Medicos(user);
            frm.Show();
        }
    }
}
