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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbrilClinica.UI
{
    public partial class AppointmentListForm : Form
    {
        private AppointmentController _appointmentController;
        private List<Appointment> _appointments;
        private Patient _patient;
        private int index;

        /// <summary>
        ///  initializes the form and instantiates an appointments list, the appointments controller
        /// </summary>
        public AppointmentListForm()
        {
            InitializeComponent();
            _appointmentController = new AppointmentController();
            _appointments = new List<Appointment>();
        }

        /// <summary>
        /// Receives the patient in charge of navigation
        /// </summary>
        /// <param name="patient"></param>
        public AppointmentListForm(Patient patient) : this()
        {
             _patient = patient;
        }

        /// <summary>
        /// update the datagrid with the list of patients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AppointmentListForm_Load(object sender, EventArgs e)
        {
            _appointmentController.CreateAppointments();
            _appointments = _appointmentController.GetAppointmentsByDniPatient(_patient.Dni);
            ActualizeDataGrid(_appointments); 
        }

        /// <summary>
        /// update the datagrid with the list of appointments
        /// </summary>
        /// <param name="appointments"></param>
        public void ActualizeDataGrid(List<Appointment> appointments)
        {
            dgv_appointments.DataSource = null;
            dgv_appointments.DataSource = appointments;
            dgv_appointments.Columns[0].HeaderText = "DNI del Paciente";
            dgv_appointments.Columns[1].HeaderText = "Especialidad";
            dgv_appointments.Columns[2].HeaderText = "Fecha";
        }

        /// <summary>
        /// select a appointment with double click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_appointment_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow P = dgv_appointments.SelectedRows[0];
                int s = dgv_appointments.Rows.IndexOf(P);
                index = s;
                Appointment selectedAppointment = _appointments[s];
            }
            catch
            {
                MessageBox.Show("No se pudo seleccionar un turno. Reintente.");
            }
        }

        /// <summary>
        /// delete a appointment to the list and set it in the appointment and user database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult option = MessageBox.Show("¿Desea eliminar el turno?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes)
            {
                _appointments.RemoveAt(index);
                index = -1;
                ActualizeDataGrid(_appointments);
                _appointmentController.SetAppointments(_appointments);
            }
        }       
    }
}
