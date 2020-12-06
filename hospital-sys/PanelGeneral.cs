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
        userController userC = new userController();
        public PanelGeneral()
        {
            InitializeComponent();
           // user = userC.searchUser(id);
            this.UserPanel.Text = "admin";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Descansos_Medicos frm = new Descansos_Medicos(0);
            frm.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Descansos_Medicos frm = new Descansos_Medicos(3);
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Descansos_Medicos frm = new Descansos_Medicos(1);
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Descansos_Medicos frm = new Descansos_Medicos(2);
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Descansos_Medicos frm = new Descansos_Medicos(5);
            frm.Show();
        }

        private void PanelGeneral_Load(object sender, EventArgs e)
        {

        }
    }
}
