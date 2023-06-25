using Abril_Clinica.Models;
using AbrilClinica.Entities.Database;
using AbrilClinica.Entities.Logs;
using AbrilClinica.Entities.Models;
using AbrilClinica.Entities.Reports;
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
using static AbrilClinica.Entities.Reports.ReportManagment;

namespace AbrilClinica.UI
{
    public partial class PatientADMForm : Form
    {
        private PatientController _patientController;
        private Patient _selectedPatient;
        private List<Patient> _patients;
        private UserLogs _userLogs;
        private int index;

        /// <summary>
        /// initializes the form and instantiates a patient list, the patient controller, and the user controller
        /// </summary>
        public PatientADMForm()
        {
            InitializeComponent();
            _patientController = new PatientController();
            _userLogs = new UserLogs();
            _patients = new List<Patient>(); 
        }

        /// <summary>
        /// Load the form, create patient data if there is none, load the patients in a list and update the datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void PatientADMForm_Load(object sender, EventArgs e)
        {
            _userLogs.Movement += UserLogs.User_Movement;
            _patients = await _patientController.GetPatients();
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
        private async void btn_add_Click(object sender, EventArgs e)
        {
            if(Validator.IsString(txb_name.Text) && Validator.IsString(txb_surname.Text) && Validator.IsString(txb_username.Text) && Validator.IsPassword(txb_password.Text) && Validator.IsDni(txb_dni.Text, out int patientDni))
            {
                Patient patient = new Patient(txb_name.Text, txb_surname.Text, txb_username.Text, txb_password.Text, true, patientDni);
                _patients.Add(patient);
                ActualizeDataGrid(_patients);
                await _patientController.Add(patient);
                _userLogs.MakeMovement("El usuario agregó un paciente");
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
                _selectedPatient = _patients[s];
                if (_selectedPatient != null)
                {
                    txb_name.Text = _selectedPatient.Name;
                    txb_surname.Text = _selectedPatient.Surname;
                    txb_username.Text = _selectedPatient.Username;
                    txb_password.Text = _selectedPatient.Password;
                    txb_dni.Text = _selectedPatient.Dni.ToString();
                }
            } catch { MessageBox.Show("No se pudo seleccionar un paciente. Reintente"); }
            
        }

        /// <summary>
        /// modifies a patient to the list and set it in the patient and user database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_modify_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = true;
            btn_delete.Enabled = true;

            if (Validator.IsString(txb_name.Text) && Validator.IsString(txb_surname.Text) && Validator.IsString(txb_username.Text) && Validator.IsPassword(txb_password.Text) && Validator.IsDni(txb_dni.Text, out int patientDni))
            {
                Patient modifiedPatient = new Patient(txb_name.Text, txb_surname.Text, txb_username.Text, txb_password.Text, true, int.Parse(txb_dni.Text));
                _patients[index] = modifiedPatient;
                index = -1;
                ActualizeDataGrid(_patients);
                await _patientController.Update(modifiedPatient);
                _userLogs.MakeMovement("El usuario modificó un paciente"); ;
                DeleteData();
            }
        }

        /// <summary>
        /// delete a patient to the list and set it in the patient and user database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_delete_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = true;
            btn_delete.Enabled = true;
            DialogResult option = MessageBox.Show("¿Desea eliminar el paciente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes)
            {
                _patients.RemoveAt(index);
                index = -1;
                ActualizeDataGrid(_patients);
                await _patientController.Delete(_selectedPatient);
                _userLogs.MakeMovement("El usuario eliminó un paciente");
                DeleteData();
            }
        }

        private void btn_CSVreport_Click(object sender, EventArgs e)
        {
            if (_patients != null)
            {
                MakeReport<Patient> doReport = ExportCSV.patientReportCSV;
                doReport(_patients);
                //ExportCSV.patientReportCSV(_patients);
                MessageBox.Show("Se ha creado el reporte exitosamente");
                _userLogs.MakeMovement("El usuario creó un reporte de pacientes CSV");
            }
            else
            {
                MessageBox.Show("No se pudo crear el reporte. Reintente.");
            }
            
        }

        private void btn_JSONreport_Click(object sender, EventArgs e)
        {
            if (_patients != null)
            {
                MakeReport<Patient> doReport = ExportJSON.PatientReportJSON;
                doReport(_patients);

                //ExportJSON.PatientReportJSON(_patients);
                MessageBox.Show("Se ha creado el reporte exitosamente");
                _userLogs.MakeMovement("El usuario creó un reporte de pacientes JSON");
            }
            else
            {
                MessageBox.Show("No se pudo crear el reporte. Reintente.");
            }
               
        }
    }
}
