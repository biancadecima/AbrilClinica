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
        private User _user;
        private Patient _patient;
        private List<Patient> _patients;
        private int index = -1;
        public PatientADMForm()
        {
            InitializeComponent();
        }

        public PatientADMForm(User user) : this()
        {
            _user = user;
        }
        private void PatientADMForm_Load(object sender, EventArgs e)
        {
            _patients = Harcoder.HardcodePatients();
            ActualizeDataGrid(_patients);
        }
        public void ActualizeDataGrid(List<Patient> patients)
        {
            dgv_patients.DataSource = null;
            dgv_patients.DataSource = _patients;// establece que una coleccion sea su base de datos
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

                ActualizeDataGrid(_patients);
            }
            else
            {
                MessageBox.Show("No se pudo agregar al paciente. Reintente.");
            }
            
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = false;
            btn_delete.Enabled = true;

            // tendria que validar?
            Patient modifiedPatient = new Patient(txb_name.Text, txb_surname.Text, txb_username.Text, txb_password.Text, true, int.Parse(txb_dni.Text));
            ActualizeDataGrid(_patients);

        }

        private void dgv_patients_DoubleClick(object sender, EventArgs e)
        {
            btn_add.Enabled = false;
            btn_modify.Enabled = true;
            btn_delete.Enabled = true;

            DataGridViewRow P = dgv_patients.SelectedRows[0];
            int s = dgv_patients.Rows.IndexOf(P);
            index= s;
            Patient selectedPatient = _patients[s]; 
            if (selectedPatient != null)
            {
                txb_name.Text = selectedPatient.Name;
                txb_surname.Text = selectedPatient.Surname;
                txb_username.Text = selectedPatient.Username;
                txb_password.Text = selectedPatient.Password;
                txb_dni.Text = selectedPatient.Dni.ToString(); 
            }
                         
              
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult option = MessageBox.Show("Desea eliminar el paciente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes)
            {
                //_patients.RemoveAt();

            }
        }

       
    }
}
