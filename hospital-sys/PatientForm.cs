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
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            patientController patientC = new patientController();
            patientModel patient= new patientModel();
            patient.Name = txtName.Text;
            patient.Last_name = txtApp.Text;
            patient.Gender =Int32.Parse( txtGenero.Text);
            patient.Dni = txtDni.Text;
            patient.Grade = txtGrado.Text;
            patient.Sit_admin = txtSitAdmin.Text;
            patient.State_pml = txtStatePml.Text;
            patient.Arma = txtArma.Text;
            patient.Guarnicion = txtGuarnicion.Text;

            if (patientC.createUser(patient))
            {
                MessageBox.Show("Registro Exitoso!!");
                this.Hide();

            }
            else
            {
                MessageBox.Show("Error en Registrar Compruebe los datos !!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             txtName.Clear();
             txtApp.Clear();
             txtGenero.Clear();
             txtDni.Clear();
             txtGrado.Clear();
             txtSitAdmin.Clear();
             txtStatePml.Clear();
             txtArma.Clear();
             txtGuarnicion.Clear();
        }

        void llenarCmb()
        {
            cmbController cmb = new cmbController();
            cmbCategoria.DataSource = cmb.getCategories();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
