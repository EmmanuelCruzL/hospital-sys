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
        int operation;
        PatientModel patient;
       
        // OPERATION 1 == NUEVO - GAURDAR
        // OPERAATION 2 == ACTUALIZAR
        public PatientForm(int op , PatientModel p)
        {
            InitializeComponent();
            this.operation = op;
            this.patient = p;
            llenarCmb();
            if (operation == 2) {
                txtName.Text = patient.Name;
                txtApp.Text = patient.Last_name;
                txtGenero.SelectedItem = patient.Gender;
                txtDni.Text = patient.Dni;
                txtGrado.Text = patient.Grade;
                txtSitAdmin.Text = patient.Sit_admin;
                txtStatePml.Text = patient.State_pml;
                txtArma.Text = patient.Arma;
                txtGuarnicion.Text = patient.Guarnicion;
                cmbCategoria.SelectedItem = patient.CatetegoryValue;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PatientController patientC = new PatientController();

            if (operation == 1)
            {                
                patient = new PatientModel();
                patient.Name = txtName.Text;
                patient.Last_name = txtApp.Text;
                patient.GenderId = txtGenero.SelectedIndex;
                patient.Dni = txtDni.Text;
                patient.Grade = txtGrado.Text;
                patient.Sit_admin = txtSitAdmin.Text;
                patient.State_pml = txtStatePml.Text;
                patient.Arma = txtArma.Text;
                patient.Guarnicion = txtGuarnicion.Text;
                patient.Category = int.Parse(cmbCategoria.SelectedValue.ToString());
                DateTime localDate = DateTime.Now;
                patient.Created = localDate.ToString("dd/MM/yyyy HH:mm");
                patient.Unit = txtUnidad.Text;
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
            else {

                patient.Name = txtName.Text;
                patient.Last_name = txtApp.Text;
                patient.GenderId =  txtGenero.SelectedIndex;
                patient.Dni = txtDni.Text;
                patient.Grade = txtGrado.Text;
                patient.Sit_admin = txtSitAdmin.Text;
                patient.State_pml = txtStatePml.Text;
                patient.Arma  = txtArma.Text;
                patient.Guarnicion = txtGuarnicion.Text;
                patient.Category = int.Parse(cmbCategoria.SelectedValue.ToString());
                patient.Unit = txtUnidad.Text;

                if (patientC.editUser(patient))
                {
                    MessageBox.Show("Actualización Exitosa!!");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error en Registrar Compruebe los datos !!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             txtName.Clear();
             txtApp.Clear();
            txtGenero.SelectedIndex = 0;
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
            cmbCategoria.DisplayMember = "name";
            cmbCategoria.ValueMember = "category_id";
            cmbCategoria.DataSource = cmb.getCategories();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
