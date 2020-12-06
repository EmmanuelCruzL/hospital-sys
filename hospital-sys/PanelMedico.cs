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
        userController users = new userController();
        patientController patient = new patientController();
        public Descansos_Medicos(int page)
        {
            InitializeComponent();
            CargarDatos();
            this.tabControl1.SelectedIndex = page;
           /* userText.Text = user.Name;
            MessageBox.Show(user.Id.ToString());
            MessageBox.Show(user.User_type.ToString());
            if(user.User_type == 1)
            {
                this.tabControl1.TabPages.Remove(userPage);
            //}*/
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
            PatientForm patient = new PatientForm();
            patient.ShowDialog();
            CargarDatos();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DescansoForm frm = new DescansoForm();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PatientForm frmUser = new PatientForm();
            frmUser.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserForm frmUser = new UserForm();
            frmUser.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public  void CargarDatos()
        {
            
          

            

            UsuariosT.DataSource = users.getUsers();
            pacienteT.DataSource = patient.getPatients();


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            UserForm frmUser = new UserForm();
            frmUser.ShowDialog();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            userModel user = new userModel();
            if (UsuariosT.SelectedRows.Count > 0)
            {
                user.Id = Int32.Parse(UsuariosT.CurrentRow.Cells["ID"].Value.ToString());
                UserForm userForm = new UserForm(user.Id);
                userForm.ShowDialog();
            }

        }

        private void Descansos_Medicos_Load(object sender, EventArgs e)
        {

        }
    }
}
