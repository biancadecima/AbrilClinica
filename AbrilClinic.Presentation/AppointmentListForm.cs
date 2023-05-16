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

        public AppointmentListForm()
        {
            InitializeComponent();
            _appointmentController = new AppointmentController();
            _appointments = new List<Appointment>();
        }

        public AppointmentListForm(Patient patient) : this()
        {
             _patient = patient;
        }

        private void AppointmentListForm_Load(object sender, EventArgs e)
        {
            _appointments = _appointmentController.GetAppointmentsByDniPatient(_patient.Dni);
            ActualizeDataGrid(_appointments); 
        }

        public void ActualizeDataGrid(List<Appointment> appointments)
        {
            dgv_appointments.DataSource = null;
            dgv_appointments.DataSource = appointments;
        }

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
                MessageBox.Show("Presione sobre la flecha en la columna izquierda para seleccionar un turno.");
            }
        }

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
