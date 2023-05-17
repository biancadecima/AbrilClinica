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
    public partial class AppointmentDMForm : Form
    {
        private AppointmentController _appointmentController;
        private List<Appointment> _appointments;
        private int index;

        /// <summary>
        /// initializes the form, instantiates the appointment controller and a list
        /// </summary>
        public AppointmentDMForm()
        {
            InitializeComponent();
            _appointmentController= new AppointmentController();
            _appointments= new List<Appointment>();
        }

        /// <summary>
        /// Load the form, create appointment data if there is none, load the appointments in a list and update the datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AppointmentDMForm_Load(object sender, EventArgs e)
        {
            _appointmentController.CreateAppointments();
            _appointments = _appointmentController.GetAppointments();
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
        }

        /// <summary>
        /// removes the data loaded in the textboxes
        /// </summary>
        public void DeleteData()
        {
            txb_dniPatient.Text = string.Empty;
            cbx_specialField.Text = string.Empty;
        }

        /// <summary>
        /// select an appointment with double click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_appointments_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow P = dgv_appointments.SelectedRows[0];
                int s = dgv_appointments.Rows.IndexOf(P);
                index = s;
                Appointment selectedAppointment = _appointments[s];
                if (selectedAppointment != null)
                {
                    txb_dniPatient.Text = selectedAppointment.DniPatient.ToString();
                    cbx_specialField.SelectedItem = selectedAppointment.SpecialField;
                    dtp_appntDate.Value = selectedAppointment.Date;
                }
            }
            catch
            {
                MessageBox.Show("Presione sobre la flecha en la columna izquierda para seleccionar un turno.");
            }
        }

        /// <summary>
        /// modifies a appointment to the list and set it in the appointment and user database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_modify_Click(object sender, EventArgs e)
        {
            if (Validator.IsDni(txb_dniPatient.Text, out int patientDni) && Validator.IsString(cbx_specialField.SelectedItem.ToString()!))
            {
                Appointment modifiedAppointment = new Appointment(_appointments[index].Id, patientDni, cbx_specialField.SelectedItem.ToString()!, dtp_appntDate.Value);
                _appointments[index] = modifiedAppointment;
                index = -1;
                ActualizeDataGrid(_appointments);
                _appointmentController.SetAppointments(_appointments);
                DeleteData();
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
                DeleteData();
            }
        }

        
    }
}
