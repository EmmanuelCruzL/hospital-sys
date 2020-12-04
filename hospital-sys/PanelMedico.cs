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
    public partial class Descansos_Medicos : Form
    {
        public Descansos_Medicos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserForm frmUser = new UserForm();
            frmUser.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DescansoForm frm = new DescansoForm();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UserForm frmUser = new UserForm();
            frmUser.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserForm frmUser = new UserForm();
            frmUser.Show();
        }
    }
}
