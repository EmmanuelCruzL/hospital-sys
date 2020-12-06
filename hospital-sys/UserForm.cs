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
    public partial class UserForm : Form
    {
        userController userC = new userController();
        userModel user = new userModel(); 
        public UserForm()
        {
            InitializeComponent();
            cargarDepartaments();
        }
        public UserForm(int id)
        {
            InitializeComponent();
            cargarDepartaments();
            
            user = userC.searchUser(id);
            MessageBox.Show(user.Name);
           
            this.txtApellido.Text = user.Last_name;

            this.txtClave.Text = user.Password;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            userModel user = new userModel();
            user.Name = txtName.Text;
            user.Last_name = txtApellido.Text;
            user.Password = txtApellido.Text;
            user.Status = 1;
            user.User_type = 1;
            user.Departament = 1;
            user.Specialty = 1;
            if (userC.createUser(user))
            {
                MessageBox.Show("Registro Exitoso!!");
                this.Hide();

            }
            else
            {
                MessageBox.Show("Error en Registrar Compruebe los datos !!");
            }
        }

        void cargarDepartaments()
        {
            cmbController dc = new cmbController();
            cmbDepartaments.DisplayMember = "name";
            cmbDepartaments.ValueMember = "departament_id";
            cmbDepartaments.DataSource = dc.getDepartaments();
            cmbSpecialties.DisplayMember = "name";
            cmbSpecialties.ValueMember = "specialty_id";
            cmbSpecialties.DataSource = dc.getSpecialties();
        }

        private void btmClean_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtApellido.Clear();
            txtClave.Clear();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
