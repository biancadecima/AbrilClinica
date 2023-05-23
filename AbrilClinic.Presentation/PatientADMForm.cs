using Abril_Clinica.Models;
using AbrilClinica.Entities.Database;
using AbrilClinica.Entities.Models;
using AbrilClinica.Entities.Utilities;
using Microsoft.VisualBasic.ApplicationServices;
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
        private int index;

        /// <summary>
        /// initializes the form and instantiates a patient list, the patient controller, and the user controller
        /// </summary>
        public PatientADMForm()
        {
            InitializeComponent();
            _patientController = new PatientController();
            _userController = new UserController();
            _patients = new List<Patient>(); 
        }

        /// <summary>
        /// Load the form, create patient data if there is none, load the patients in a list and update the datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PatientADMForm_Load(object sender, EventArgs e)
        {
            _patientController.CreatePatients();
            _patients = _patientController.GetPatients();
            ActualizeDataGrid(_patients);
        }

        /// <summary>
        /// update the datagrid with the list of patients
        /// </summary>
        /// <param name="patients"></param>
        public void ActualizeDataGrid(List<Patient> patients)
        {
            dgv_patients.DataSource = null;
            dgv_patients.DataSource = patients;
            dgv_patients.Columns[0].HeaderText = "DNI";
            dgv_patients.Columns[1].HeaderText = "Nombre";
            dgv_patients.Columns[2].HeaderText = "Apellido";
            dgv_patients.Columns[3].HeaderText = "Nombre de Usuario";
            dgv_patients.Columns[4].HeaderText = "Contraseña";
        }

        /// <summary>
        /// removes the data loaded in the textboxes
        /// </summary>
        public void DeleteData()
        {
            txb_name.Text = string.Empty;
            txb_surname.Text = string.Empty;
            txb_username.Text = string.Empty;
            txb_password.Text = string.Empty;
            txb_dni.Text = string.Empty;
        }

        /// <summary>
        /// add a patient to the list and set it in the patient and user database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// select a patient with double click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            } catch { MessageBox.Show("No se pudo seleccionar un paciente. Reintente"); }
            
        }

        /// <summary>
        /// modifies a patient to the list and set it in the patient and user database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_modify_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = true;
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

        /// <summary>
        /// delete a patient to the list and set it in the patient and user database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = true;
            btn_delete.Enabled = true;
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
