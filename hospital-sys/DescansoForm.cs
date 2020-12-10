using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hospital_sys.Models;
using hospital_sys.Controllers;

namespace hospital_sys
{
    public partial class DescansoForm : Form
    {
        workBreakController workC = new workBreakController();
        workBreakModel workModel = new workBreakModel();
        User user ;
        PatientModel Patient ;
        PatientController patientC = new PatientController();
        bool edit = false;
        public DescansoForm(User user ,PatientModel patient)
        {
            InitializeComponent();
            this.user = user;
            this.Patient = patient;
            chargeData(edit);
        }
        public DescansoForm(User user,Models.workBreakModel workModel,PatientModel patient, bool edit)
        {
            InitializeComponent();
            
            this.edit = true;
            this.user = user;
            this.workModel = workModel;
            this.Patient = patient;
            
            this.workModel = workC.searchWorkBreak(workModel.Id);
            chargeData(edit);
            lbTitle.Text = "Editar Descanso";
            btnSave.Text = "Actualizar";


        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            workModel.Doc_status = "Activo";
            workModel.Diagnostic = txtDiagnoistic.Text;
            workModel.Date_pmi = dtPPmi.Value.ToString("yyyy-MM-dd HH:mm:ss:fff");
            workModel.Start_date = dtpInitial.Value.ToString("yyyy-MM-dd HH:mm:ss:fff"); ;
            workModel.End_date = dtpEnd.Value.ToString("yyyy-MM-dd HH:mm:ss:fff");;
            workModel.Situation = txtSituation.Text;
            workModel.Unit = 1;
            workModel.User_id = user.Id;
            //workModel.Patient_id = Patient.Id;
            if (edit)
            {
                if (workC.EditWorkBreak(workModel))
                {
                    MessageBox.Show("Actualización Exitosa!!");
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Error al actualizar Compruebe los datos !!");
                }
            }
            else
            {                
                if (workC.CreateWorkBreak(workModel))
                {
                    MessageBox.Show("Registro Exitoso!!");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error en Registrar Compruebe los datos !!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtClean_Click(object sender, EventArgs e)
        {
            txtEstado.Clear();
            txtSituation.Clear();      
            txtDiagnoistic.Clear();
            //txtUnity.Clear();
            
        }

        void chargeData(bool edit)
        {

            txtName.Text = this.Patient.Name;
            txtApp.Text = this.Patient.Last_name;
            txtUser.Text = user.Name;
            
            
            if (edit)
            {
                txtEstado.Text = this.workModel.Doc_status;
                txtDiagnoistic.Text = this.workModel.Diagnostic;
                txtSituation.Text = this.workModel.Situation;
                txtSituation.Text = this.workModel.Situation;
                dtPPmi.Text = this.workModel.Date_pmi;
                dtpInitial.Text = this.workModel.Start_date;
                dtpEnd.Text = this.workModel.End_date;
            }


        }

        private void DescansoForm_Load(object sender, EventArgs e)
        {

        }

        private void dtPPmi_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
