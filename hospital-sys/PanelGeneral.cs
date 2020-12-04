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
        public PanelGeneral()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Descansos_Medicos frm = new Descansos_Medicos();
            frm.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Descansos_Medicos frm = new Descansos_Medicos();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Descansos_Medicos frm = new Descansos_Medicos();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Descansos_Medicos frm = new Descansos_Medicos();
            frm.Show();
        }
    }
}
