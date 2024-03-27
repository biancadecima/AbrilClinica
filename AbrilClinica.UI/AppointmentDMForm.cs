using AbrilClinica.Entities.Models;
using AbrilClinica.Entities.Database;
using AbrilClinica.Entities.Logs;
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
using User = AbrilClinica.Entities.Models.User;

namespace AbrilClinica.UI
{
    public partial class AppointmentDMForm : Form
    {
        private AppointmentController _appointmentController;
        private List<Appointment> _appointments;
        private Appointment _selectedAppointment;
        private User _user;
        private UserLogs _userLogs;
        private int index;

        /// <summary>
        /// initializes the form, instantiates the appointment controller and a list
        /// </summary>
        public AppointmentDMForm()
        {
            InitializeComponent();
            _appointmentController= new AppointmentController();
            _appointments = new List<Appointment>();
            _selectedAppointment = new Appointment();
            _user = new User();
            _userLogs = new UserLogs(_user);
        }

        /// <summary>
        /// Load the form, create appointment data if there is none, load the appointments in a list and update the datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void AppointmentDMForm_Load(object sender, EventArgs e)
        {
            _appointments = await _appointmentController.GetAppointments();
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
                _selectedAppointment = _appointments[s];
                if (_selectedAppointment != null)
                {
                    txb_dniPatient.Text = _selectedAppointment.DniPatient.ToString();
                    cbx_specialField.SelectedItem = _selectedAppointment.SpecialField;
                    dtp_appntDate.Value = _selectedAppointment.Date;
                }
            }
            catch
            {
                MessageBox.Show("No se pudo seleccionar un turno. Reintente.");
            }
        }

        /// <summary>
        /// modifies a appointment to the list and set it in the appointment and user database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_modify_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validator.IsDni(txb_dniPatient.Text, out int patientDni) && Validator.IsString(cbx_specialField.SelectedItem.ToString()!))
                {
                    Appointment modifiedAppointment = new Appointment(_appointments[index].Id, patientDni, cbx_specialField.SelectedItem.ToString()!, dtp_appntDate.Value);
                    _appointments[index] = modifiedAppointment;
                    index = -1;
                    ActualizeDataGrid(_appointments);
                    await _appointmentController.Update(modifiedAppointment);
                    DeleteData();
                    _user.MakeMovement("El usuario modifico un turno");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo realizar la acción. Reintente.");
            }
        }

        /// <summary>
        /// delete a appointment to the list and set it in the appointment and user database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult option = MessageBox.Show("¿Desea eliminar el turno?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (option == DialogResult.Yes)
                {
                    _appointments.RemoveAt(index);
                    index = -1;
                    ActualizeDataGrid(_appointments);
                    await _appointmentController.Delete(_selectedAppointment);
                    DeleteData();
                    _user.MakeMovement("El usuario eliminó un turno");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo realizar la accion. Reintente.");
            }
        }

        private void btn_CSVreport_Click(object sender, EventArgs e)
        {
            if (_appointments != null)
            {
                MakeReport<Appointment> doReport = ExportCSV.appointmentReportCSV;
                doReport(_appointments);
                MessageBox.Show("Se ha creado el reporte exitosamente");
                _user.MakeMovement("El usuario creó un reporte de turnos CSV");
            }
            else
            {
                MessageBox.Show("No se pudo crear el reporte. Reintente.");
            }
                
        }

        private void btn_JSONreport_Click(object sender, EventArgs e)
        {
            if (_appointments != null)
            {
                MakeReport<Appointment> doReport = ExportJSON.AppointmentReportJSON;
                doReport(_appointments);
                MessageBox.Show("Se ha creado el reporte exitosamente");
                _user.MakeMovement("El usuario creó un reporte de turnos JSON");
            }
            else
            {
                MessageBox.Show("No se pudo crear el reporte. Reintente.");
            }
                
        }
    }
}
