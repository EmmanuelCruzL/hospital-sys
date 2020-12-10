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
        UserController userC = new UserController();
        User user = new User(); 
        int edit = 0;
        public UserForm()
        {
            InitializeComponent();
            cargarDepartaments();
        }
        public UserForm(User user)
        {
            
            InitializeComponent();
            cargarDepartaments();
            this.lbMode.Text = "EDITAR USUARIO";
            this.btnSave.Text = "Actualizar";
            this.user = user;
            edit = 1;
            editMode(user);
            
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.user.Name = txtName.Text;
            this.user.Last_name = txtApellido.Text;
            this.user.Password = txtApellido.Text;
            this.user.Status = typeUser();
            this.user.User_type = cmbTipo.SelectedIndex;
            this.user.Departament = Int32.Parse(cmbDepartaments.SelectedValue.ToString());
            this.user.Specialty = Int32.Parse(cmbSpecialties.SelectedValue.ToString());
            if (edit == 0)
            {
                                
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
            else
            {
                if (userC.editUser(user))
                {
                    MessageBox.Show("Actualización Exitosa!!");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error al Actualizar");
                }
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

        private void cmbDepartaments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSpecialties_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        int typeUser()
        {
            int option = -1;
            if (cmbTipo.SelectedIndex != -1)
            {
                option = cmbTipo.SelectedIndex;
            }
            else
            {
                MessageBox.Show("Por Favor llenar Campos");
            }

            return option;
        } 

        void editMode(User user) 
        {
            txtName.Text = user.Name;
            txtApellido.Text = user.Last_name;
            txtClave.Text = user.Password;
            cmbTipo.SelectedIndex = user.User_type;
            cmbSpecialties.SelectedValue = user.Specialty;            
            cmbDepartaments.SelectedValue = user.Departament;            
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
