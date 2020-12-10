using hospital_sys.Controllers;
using hospital_sys.Models;
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
    public partial class FichaMedica : Form
    {

        PatientModel patient;
        User currentUser;
        cmbController catalogControllers;
        AppointmentController appController;
        DataTable appointmentsOfPatient;
        public FichaMedica(PatientModel p, User c)
        {
            InitializeComponent();
            this.currentUser = c;
            this.patient = p;
            this.catalogControllers = new cmbController();
            this.appController = new AppointmentController();
            this.appointmentsOfPatient = this.appController.getAppointmentsByPatientId(this.patient.Id, this.currentUser.Id);
            txtId.Text = "000" + p.Id + "";
            txtNameApp.Text = p.Name + " " + p.Last_name;
            txtGrade.Text = p.Grade;
            txtUnidad.Text = p.Unit;
            txtAdmin.Text = p.Sit_admin;
            txtSexo.Text = p.GenderId == 0 ? "Masculino" : "Femenino";
            txtDni.Text = p.Dni;            
            txtSexo.Text = p.Gender;
            txtArma.Text = p.Arma;
            txtCategoria.Text = catalogControllers.findCategoryByName(p.CatetegoryValue).Name;
            txtSpecialty.Text = catalogControllers.findSpecialtyById(currentUser.Specialty).Name;
            txtGuarnicion.Text = p.Guarnicion;
            txtActasMédicas.Text = "0-"+this.appointmentsOfPatient.Rows.Count+"";

            txtDactasMedicas.Text = "0-" + this.appointmentsOfPatient.Rows.Count + "";
            txtDNumEspecialidad.Text = currentUser.Specialty+"";
            txtDEspeciliad.Text = txtSpecialty.Text;
            txtDNAditivo.Text = txtId.Text;
            txtDNombrePaciente.Text = txtNameApp.Text;
            txtDGrado.Text = txtGrade.Text;
            txtDUnidad.Text = txtUnidad.Text;
            txtDSitAdmin.Text = txtAdmin.Text;
            t.Text = txtSexo.Text;
            txtDDNI.Text = txtDni.Text;
            txtDArma.Text = txtArma.Text;
            txtDGuarnicion.Text = txtGuarnicion.Text;
            txtDCategoria.Text = txtCategoria.Text;
            txtDDescanso.SelectedIndex = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void FichaMedica_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Appointment ap = new Appointment();
                ap.IsWorkBreak = txtDDescanso.SelectedIndex;
                ap.UserId = currentUser.Id;
                ap.PatientId = patient.Id;
                ap.MedicalHistory = txtHistory.Text;
                ap.ClinicalExamination = txtClinicTest.Text;
                ap.CurrentDisease = txtCurrentDisease.Text;
                ap.DiagnosticSupport = txtSupportDiagnostic.Text;
                ap.Diagnosis = txtDiagnosis.Text;
                ap.Etilogy = txtEtiologia.Text;
                ap.Treatment = txtTratamiento.Text;
                ap.Evolution = txtEvolucion.Text;
                ap.Forcecat = txtPronostico.Text;
                ap.WorkRelize = txtTrabajoArealizar.Text;
                ap.MagnitudeDependecny = txtMagnitud.Text;
                ap.DregreeDpendency = txtGradoDependencia.Text; 
                ap.CommentsServiceDisease = txtRelationServiceDisease.Text;
                ap.AproximateTime = txtTiempoAproximado.Text;
                ap.Guarnizion = txtGuarnizacionServir.Text;
                ap.DateMedicalMeeting = txtMeetingDate.Value;
                ap.NextEvaluationDate = txtNextDateEVALUTATION.Value;
                ap.Conclusion = txtResume.Text;

                if (appController.saveAppointment(ap))
                {
                    MessageBox.Show("Revisión registrada con exito");
                    this.Hide();
                }
                else {
                    MessageBox.Show("Error al registrar, revise los datos e intente de nuevo!");
                }
            }
            catch (Exception es) { }
        }
    }
}
