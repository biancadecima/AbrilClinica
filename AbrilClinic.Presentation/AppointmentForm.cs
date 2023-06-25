using Abril_Clinica.Models;
using AbrilClinica.Entities.Database;
using AbrilClinica.Entities.Logs;
using AbrilClinica.Entities.Models;
using AbrilClinica.Entities.Utilities;
using Google.Type;
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
using DateTime = System.DateTime;

namespace AbrilClinica.UI
{
    public partial class AppointmentForm : Form
    {
        private Patient _patient;
        private AppointmentController _appointmentController;
        private List<Appointment> _appointments;
        private UserLogs _userLogs;

        /// <summary>
        /// initialize the form, instantiate the appointments controller and create a list
        /// </summary>
        public AppointmentForm()
        {
            InitializeComponent();
            _appointmentController = new AppointmentController();
            _appointments = new List<Appointment>();
            _userLogs = new UserLogs();
        }

        /// <summary>
        /// Receives the patient in charge of navigation
        /// </summary>
        /// <param name="patient"></param>
        public AppointmentForm(Patient patient): this()
        {
            _patient = patient;

        }

        /// <summary>
        /// Load the form, create appointment data if there is none, load the appointments in a list and sets the appointments date values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void AppointmentForm_Load(object sender, EventArgs e)
        {
            _userLogs.Movement += UserLogs.User_Movement;
            _appointments = await _appointmentController.GetAppointments();
            this.dtp_appntDate.MinDate = new System.DateTime(2023, 5, 5, 0, 0, 0, 0);
            this.dtp_appntDate.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            
        }

        /// <summary>
        /// add a appointment to the list and set it in the appointment database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_request_Click(object sender, EventArgs e)
        {
            int id = Appointment.NewIdAppointment(_appointments);
            if (Validator.IsDni(txb_dniPatient.Text, out int patientDni) && Validator.IsString(cbx_specialField.SelectedItem.ToString()!) && Validator.IsDniSameAsDniPatient(_patient.Dni, patientDni))
            {
                Appointment appointment = new Appointment(id, patientDni, cbx_specialField.SelectedItem.ToString()!, dtp_appntDate.Value);
                _appointments.Add(appointment);
                await _appointmentController.Add(appointment);
                MessageBox.Show("Turno agendado con éxito.");
                _userLogs.MakeMovement("El usuario solicitó un turno");
            }
            else
            {
                MessageBox.Show("No se pudo agregar el turno. Reintente.");
            } 
        }

        
    }
}
