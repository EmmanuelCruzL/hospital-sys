using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using hospital_sys.Controllers;

namespace hospital_sys
{
    public partial class Descansos_Medicos : Form
    {
        User currentUser;
        UserController users = new UserController();
        Controllers.workBreakController workC = new Controllers.workBreakController();
        PatientController patient = new PatientController();
        cmbController cmb = new cmbController();
        public Descansos_Medicos(int page, User current)
        {
            InitializeComponent();
            this.currentUser = current;
            this.userText.Text = $"{this.currentUser.Name} - {Global.userTypes[this.currentUser.User_type]}";
            dataLoader();
            this.tabControl1.SelectedIndex = page;
            this.cargarDepartaments();
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
            PatientForm patient = new PatientForm(1, null);
            patient.ShowDialog();
            dataLoader();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (pacienteT.SelectedRows.Count > 0) {
                PatientModel p = new PatientModel();
                p.Id = int.Parse(pacienteT.SelectedRows[0].Cells[0].Value.ToString());
                p.Name = pacienteT.SelectedRows[0].Cells[1].Value.ToString();
                p.Last_name = pacienteT.SelectedRows[0].Cells[2].Value.ToString();
                p.Gender = pacienteT.SelectedRows[0].Cells[3].Value.ToString();
                p.Dni = pacienteT.SelectedRows[0].Cells[4].Value.ToString();
                p.Grade = pacienteT.SelectedRows[0].Cells[5].Value.ToString();
                p.Sit_admin = pacienteT.SelectedRows[0].Cells[6].Value.ToString();
                p.State_pml = pacienteT.SelectedRows[0].Cells[7].Value.ToString();
                p.Arma = pacienteT.SelectedRows[0].Cells[8].Value.ToString();
                p.Guarnicion = pacienteT.SelectedRows[0].Cells[9].Value.ToString();
                p.CatetegoryValue = pacienteT.SelectedRows[0].Cells[10].Value.ToString();

                PatientForm frmUser = new PatientForm(2,p);
                frmUser.ShowDialog();
            }
            else{
                MessageBox.Show("Selecciona un paciente en la tabla");
            }
            dataLoader();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (DescansosT.SelectedRows.Count > 0)
            {
                Models.workBreakModel w = new Models.workBreakModel();
                PatientModel p = new PatientModel();
                for (int i=0;i< DescansosT.SelectedRows[0].Cells.Count;i++)
                {
                    Console.WriteLine(i + " - " + DescansosT.SelectedRows[0].Cells[i].Value.ToString());
                }
                w.Id = int.Parse(DescansosT.SelectedRows[0].Cells[0].Value.ToString());
                p.Name = (DescansosT.SelectedRows[0].Cells[1].Value.ToString());
                p.Last_name = (DescansosT.SelectedRows[0].Cells[2].Value.ToString());
                w.Doc_status = (DescansosT.SelectedRows[0].Cells[3].Value.ToString());
                w.Date_pmi = (DescansosT.SelectedRows[0].Cells[4].Value.ToString());
                w.Start_date = (DescansosT.SelectedRows[0].Cells[5].Value.ToString());
                w.End_date = (DescansosT.SelectedRows[0].Cells[6].Value.ToString());
                w.Situation = (DescansosT.SelectedRows[0].Cells[7].Value.ToString());
                p.Unit = (DescansosT.SelectedRows[0].Cells[9].Value.ToString());
                


                DescansoForm frmDescanso = new DescansoForm(this.currentUser, w,p,true);
                frmDescanso.ShowDialog();

            }
            else
            {
                MessageBox.Show("Selecciona un paciente en la tabla");
            }
            dataLoader();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public  void dataLoader()
        {
            pacienteT.DataSource = patient.getPatients();
            UsuariosT.DataSource = users.getUsers();
            DescansosT.DataSource = workC.getWorkBreaks(currentUser.Id);
            notifyT.DataSource = workC.getWorkBreaks(currentUser.Id);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            UserForm frmUser = new UserForm();
            frmUser.ShowDialog();
            dataLoader();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (UsuariosT.SelectedRows.Count > 0)
            {
                currentUser  = new User();
                currentUser.Id = int.Parse(UsuariosT.SelectedRows[0].Cells[0].Value.ToString());
                DialogResult dialogResult = MessageBox.Show("¿Seguro de eliminar el registro?", "Atención", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (users.delUser(currentUser))
                    {
                        MessageBox.Show("Eliminado correctamente!");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Error al eliminar");
                }
            }
            else
            {
                MessageBox.Show("Selecciona un paciente en la tabla");
            }
            dataLoader();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            User user = new User();
            if (UsuariosT.SelectedRows.Count > 0)
            {
                user.Id = Int32.Parse(UsuariosT.CurrentRow.Cells["ID"].Value.ToString());
                user.Name = (UsuariosT.CurrentRow.Cells["Nombre"].Value.ToString());
                user.Last_name = (UsuariosT.CurrentRow.Cells["Apellido"].Value.ToString());
                user.Password = (UsuariosT.CurrentRow.Cells["Contraseña"].Value.ToString());
                user.Status = Int32.Parse(UsuariosT.CurrentRow.Cells["Estado"].Value.ToString());
                user.User_type = Int32.Parse(UsuariosT.CurrentRow.Cells["Tipo"].Value.ToString());
                user.Specialty = cmb.FindSpeciality(UsuariosT.CurrentRow.Cells["Especialidad"].Value.ToString());
                user.Departament = cmb.FindDepartament(UsuariosT.CurrentRow.Cells["Departamento"].Value.ToString());
                UserForm userForm = new UserForm(user);
                userForm.ShowDialog();
                dataLoader();
            }

        }

        private void Descansos_Medicos_Load(object sender, EventArgs e)
        {
            try
            {
                pacienteT.Columns[0].Visible = false;
                reportDate.Format = DateTimePickerFormat.Custom;
                reportDate.CustomFormat = "yyyy";
                this.geenerarMock();
            }
            catch { }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            String name = txtSearch.Text;
            pacienteT.DataSource = patient.searchPatients(name);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (pacienteT.SelectedRows.Count > 0)
            {
                PatientModel p = new PatientModel();
                p.Id = int.Parse(pacienteT.SelectedRows[0].Cells[0].Value.ToString());
                DialogResult dialogResult = MessageBox.Show("¿Seguro de eliminar el registro?", "Atención", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (patient.delUser(p))
                    {
                        MessageBox.Show("Eliminado correctamente!");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }
            }
            else
            {
                MessageBox.Show("Selecciona un paciente en la tabla");
            }
            dataLoader();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

         private void button6_Click_1(object sender, EventArgs e)
        {

            if (pacienteT.SelectedRows.Count > 0)
            {
                PatientModel p = new PatientModel();
                p.Id = int.Parse(pacienteT.SelectedRows[0].Cells[0].Value.ToString());
                p.Name = pacienteT.SelectedRows[0].Cells[1].Value.ToString();
                p.Last_name = pacienteT.SelectedRows[0].Cells[2].Value.ToString();
                p.Gender = pacienteT.SelectedRows[0].Cells[3].Value.ToString();
                p.Dni = pacienteT.SelectedRows[0].Cells[4].Value.ToString();
                p.Grade = pacienteT.SelectedRows[0].Cells[5].Value.ToString();
                p.Sit_admin = pacienteT.SelectedRows[0].Cells[6].Value.ToString();
                p.State_pml = pacienteT.SelectedRows[0].Cells[7].Value.ToString();
                p.Arma = pacienteT.SelectedRows[0].Cells[8].Value.ToString();
                p.Guarnicion = pacienteT.SelectedRows[0].Cells[9].Value.ToString();
                p.CatetegoryValue = pacienteT.SelectedRows[0].Cells[10].Value.ToString();
                p.Unit = pacienteT.SelectedRows[0].Cells[11].Value.ToString();
                FichaMedica userForm = new FichaMedica(p, currentUser);
                userForm.ShowDialog();
                dataLoader();
                this.tabControl1.SelectedIndex = 2;
            }
            else
            {
                MessageBox.Show("Selecciona un paciente");
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchU_Click(object sender, EventArgs e)
        {
            String name = txtSearchU.Text;
             UsuariosT.DataSource =users.searchUsers(name);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtDescanso_Click(object sender, EventArgs e)
        {

            if (pacienteT.SelectedRows.Count > 0)
            {
                PatientModel p = new PatientModel();
                p.Id = int.Parse(pacienteT.SelectedRows[0].Cells[0].Value.ToString());
                p.Name = pacienteT.SelectedRows[0].Cells[1].Value.ToString();
                p.Last_name = pacienteT.SelectedRows[0].Cells[2].Value.ToString();
                p.Gender = pacienteT.SelectedRows[0].Cells[3].Value.ToString();
                p.Dni = pacienteT.SelectedRows[0].Cells[4].Value.ToString();
                p.Grade = pacienteT.SelectedRows[0].Cells[5].Value.ToString();
                p.Sit_admin = pacienteT.SelectedRows[0].Cells[6].Value.ToString();
                p.State_pml = pacienteT.SelectedRows[0].Cells[7].Value.ToString();
                p.Arma = pacienteT.SelectedRows[0].Cells[8].Value.ToString();
                p.Guarnicion = pacienteT.SelectedRows[0].Cells[9].Value.ToString();
                p.CatetegoryValue = pacienteT.SelectedRows[0].Cells[10].Value.ToString();
                p.Unit = pacienteT.SelectedRows[0].Cells[11].Value.ToString();
                DescansoForm frmDescanso = new DescansoForm(this.currentUser, p);
                frmDescanso.ShowDialog();

            }
            else
            {
                MessageBox.Show("Selecciona un paciente en la tabla");
            }
            dataLoader();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
           if(cmbMesD.SelectedIndex > 0 && txtPacientesD.Text != "")
            {
                DescansosT.DataSource = workC.searchWorkBreaks(txtPacientesD.Text,cmbMesD.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Seleccion un filtro");
            }
            
        }

        void cargarDepartaments()
        {
            //cmbController dc = new cmbController();            
            //cmbEspeicialidad.DisplayMember = "name";
            //cmbEspeicialidad.ValueMember = "specialty_id";
            //cmbEspeicialidad.DataSource = dc.getSpecialties();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void loadCmb()
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchNotify_Click(object sender, EventArgs e)
        {
            if (cmbMesN.SelectedIndex > 0 && txtPacienteN.Text != "")
            {
                notifyT.DataSource = workC.searchWorkBreaks(txtPacienteN.Text, cmbMesN.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Seleccion un filtro");
            }
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            int type = cbmReportype.SelectedIndex;
            int year = int.Parse(reportDate.Text);
            Report r = new Report();
            chart1.Series.Clear();
            chart1.Titles.Clear();
            List<Models.Series> datosSeries;
            if (type == 0)
            {
                datosSeries = r.getUserActivity(year);
                chart1.Series.Add("Activdad de usuarios");
                chart1.Series[0].ChartType = SeriesChartType.Line;
                for (int i = 0; i < datosSeries.Count; i++)
                {
                    Models.Series serie = datosSeries.ElementAt(i);
                    int freq = datosSeries.RemoveAll(delegate (Models.Series s)
                    {
                        return s.mes == serie.mes;
                    });
                    Console.WriteLine(serie.mes +" - "+ freq);
                    chart1.Series[0].Points.AddXY(serie.mes, freq);
                }
                chart1.Titles.Add("Actividad de usuarios");
            }
            else if (type == 2)
            {
                datosSeries = r.getDoctoresActivity(year);                
                chart1.Series.Add("Registro de Pacientes");
                chart1.Series[0].ChartType = SeriesChartType.Line;
                for (int i = 0; i < datosSeries.Count; i++)
                {
                    Models.Series serie = datosSeries.ElementAt(i);
                    int freq = datosSeries.RemoveAll(delegate (Models.Series s)
                    {
                        return s.mes == serie.mes;
                    });
                    Console.WriteLine(serie.mes + " - " + freq);
                    chart1.Series[0].Points.AddXY(serie.mes, freq);
                }
                chart1.Titles.Add("Registro de Pacientes");
            }
            else if (type == 1)
            {
                datosSeries = r.getDoctoresActivity(year);                
                chart1.Series.Add("Activdad de Doctores");
                chart1.Series[0].ChartType = SeriesChartType.Line;
                for (int i = 0; i < datosSeries.Count; i++)
                {
                    Models.Series serie = datosSeries.ElementAt(i);
                    int freq = datosSeries.RemoveAll(delegate (Models.Series s)
                    {
                        return s.mes == serie.mes;
                    });
                    Console.WriteLine(serie.mes + " - " + freq);
                    chart1.Series[0].Points.AddXY(serie.mes, freq);
                }
                chart1.Titles.Add("Actividad de Doctores");

            }
            else {
                this.geenerarMock();
            }
        }

        private void geenerarMock()
        {
            List<Models.Series> datosSeries = new List<Models.Series>
        {
            new Models.Series
            {
                mes = "JAN",
                Serie1 = 29.9m,
                Serie2 = 144.0m
            },
            new Models.Series
            {
                mes = "FEB",
                Serie1 = 71.5m,
                Serie2 = 176.0m
            },
            new Models.Series
            {
                mes = "MAR",
                Serie1 = 106.4m,
                Serie2 = 135.6m
            },
            new Models.Series
            {
                mes = "APR",
                Serie1 = 129.2m,
                Serie2 = 148.5m
            },
            new Models.Series
            {
                mes = "MAY",
                Serie1 = 144.0m,
                Serie2 = 216.4m
            },
            new Models.Series
            {
                mes = "JUN",
                Serie1 = 176.0m,
                Serie2 = 194.1m
            },
        };
            chart1.Series.Clear();  //Eliminamos cualquier serie del grafico
            chart1.DataBindTable(datosSeries, "mes"); //Enlazamos nuestra lista al grafico y le indicamos la propiedad que se usara para el eje X
            chart1.Series[0].ChartType = SeriesChartType.Line; //Tipo de grafico de linea para la serie 1
            chart1.Series[1].ChartType = SeriesChartType.Line;


        }

        private void PACIENTE_Click(object sender, EventArgs e)
        {

        }
    }
}
