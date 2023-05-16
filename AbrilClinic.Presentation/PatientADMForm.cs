using Abril_Clinica.Models;
using AbrilClinica.Entities.Database;
using AbrilClinica.Entities.Models;
using AbrilClinica.Entities.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbrilClinica.UI
{
    public partial class PatientADMForm : Form
    {
        private PatientController _patientController;
        private Patient _patient;
        private List<Patient> _patients;
        private UserController _userController;
        private User _user;
        private List<User> _users;
        private int index;
        public PatientADMForm()
        {
            InitializeComponent();
            _patientController = new PatientController();
            _userController = new UserController();
            _patients = new List<Patient>(); 
            _users = new List<User>();
        }
        
        private void PatientADMForm_Load(object sender, EventArgs e)
        {
            _patientController.CreatePatients();
            _patients = _patientController.GetPatients();
            ActualizeDataGrid(_patients);
        }
        public void ActualizeDataGrid(List<Patient> patients)
        {
            dgv_patients.DataSource = null;
            dgv_patients.DataSource = patients;
        }

        public void DeleteData()
        {
            txb_name.Text = string.Empty;
            txb_surname.Text = string.Empty;
            txb_username.Text = string.Empty;
            txb_password.Text = string.Empty;
            txb_dni.Text = string.Empty;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(Validator.IsString(txb_name.Text) && Validator.IsString(txb_surname.Text) && Validator.IsString(txb_username.Text) && Validator.IsPassword(txb_password.Text) && Validator.IsDni(txb_dni.Text, out int patientDni))
            {
                _patient = new Patient(txb_name.Text, txb_surname.Text, txb_username.Text, txb_password.Text, true, patientDni);
                _patients.Add(_patient);
                ActualizeDataGrid(_patients);
                _patientController.SetPatients(_patients);
                _userController.SetUsers(_patients);
            }
            else
            {
                MessageBox.Show("No se pudo agregar al paciente. Reintente.");
            }
        }

        private void dgv_patients_DoubleClick(object sender, EventArgs e)
        {
            try 
            {
                btn_add.Enabled = false;
                btn_modify.Enabled = true;
                btn_delete.Enabled = true;

                DataGridViewRow P = dgv_patients.SelectedRows[0];
                int s = dgv_patients.Rows.IndexOf(P);
                index = s;
                Patient selectedPatient = _patients[s];
                if (selectedPatient != null)
                {
                    txb_name.Text = selectedPatient.Name;
                    txb_surname.Text = selectedPatient.Surname;
                    txb_username.Text = selectedPatient.Username;
                    txb_password.Text = selectedPatient.Password;
                    txb_dni.Text = selectedPatient.Dni.ToString();
                }
            } catch { MessageBox.Show("Presione sobre la flecha en la columna izquierda para seleccionar un paciente"); }
            
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = false;
            btn_delete.Enabled = true;

            if (Validator.IsString(txb_name.Text) && Validator.IsString(txb_surname.Text) && Validator.IsString(txb_username.Text) && Validator.IsPassword(txb_password.Text) && Validator.IsDni(txb_dni.Text, out int patientDni))
            {
                Patient modifiedPatient = new Patient(txb_name.Text, txb_surname.Text, txb_username.Text, txb_password.Text, true, int.Parse(txb_dni.Text));
                _patients[index] = modifiedPatient;
                index = -1;
                ActualizeDataGrid(_patients);
                _patientController.SetPatients(_patients);
                _userController.SetUsers(_patients);
                DeleteData();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult option = MessageBox.Show("¿Desea eliminar el paciente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes)
            {
                _patients.RemoveAt(index);
                index = -1;
                ActualizeDataGrid(_patients);
                _patientController.SetPatients(_patients);
                _userController.SetUsers(_patients);
                DeleteData();
            }
        }      
    }
}
