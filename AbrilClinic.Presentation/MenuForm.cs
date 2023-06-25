using Abril_Clinica.Models;
using AbrilClinica.Entities.Database;
using AbrilClinica.Entities.Logs;
using AbrilClinica.Entities.Utilities;
using AbrilClinica.UI;
using Google.Cloud.Firestore.V1;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbrilClinic.Presentation
{
    public partial class MenuForm : Form
    {
        private User _user;
        private Patient _patient;
        private Admin _admin;
        private PatientController _patientController;
        private AdminController _adminController;
        private UserLogs _userLogs;
        int m, mx, my;

        /// <summary>
        /// Initializes the menu, the patient controller and the admin controller
        /// </summary>
        private MenuForm()
        {
            InitializeComponent();
            _adminController= new AdminController();
            _patientController= new PatientController();
            _userLogs = new UserLogs();
        }

        /// <summary>
        /// Overloads the initialization constructor and receives the user who performs the navigation
        /// </summary>
        /// <param name="user"></param>
        public MenuForm(User user):this()
        {
            _user = user;

        }

        /// <summary>
        /// Loads the Main Menu form, makes it mdi parent and manages the button view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async  void MenuForm_Load(object sender, EventArgs e)
        {
            _userLogs.Movement += UserLogs.User_Movement;
            IsMdiContainer = true;
            if (Session.IsAnAdminSession(_user))
            {
                // es admin
                btn_appointment.Visible = false;
                btn_apptview.Visible = false;
                btn_doclistview.Visible = false;
                _admin = await _adminController.GetAdminByUsername(_user.Username);
            }
            else
            {
                //es paciente
                btn_apptmngmt.Visible = false;
                btn_patientmngmt.Visible = false;
                _patient = await _patientController.GetPatientByUsername(_user.Username);
            }

        }

        /// <summary>
        /// Instantiate and display the appointment form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_appointment_Click(object sender, EventArgs e)
        {
            var childAppointmentForm = new AppointmentForm(_patient);
            _userLogs.MakeMovement("El usuario ingresó a Solicitud de Turnos");
            childAppointmentForm.TopLevel= false;
            childAppointmentForm.MdiParent = this;
            childAppointmentForm.WindowState = FormWindowState.Maximized;
            childAppointmentForm.BringToFront();
            childAppointmentForm.Dock= DockStyle.Fill;
            pnl_container.Controls.Add(childAppointmentForm);
            pnl_container.Tag = childAppointmentForm;
            childAppointmentForm.Activate();
            childAppointmentForm.Show();
            
        }

        /// <summary>
        /// Instantiate and display the appointment view form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_apptview_Click(object sender, EventArgs e)
        {
            var childAppointmentListForm = new AppointmentListForm(_patient);
            _userLogs.MakeMovement("El usuario ingresó a Mis Turnos Pendientes");
            childAppointmentListForm.MdiParent = this;
            childAppointmentListForm.WindowState = FormWindowState.Maximized;
            childAppointmentListForm.Dock = DockStyle.Fill;
            pnl_container.Controls.Add(childAppointmentListForm);
            pnl_container.Tag = childAppointmentListForm;
            childAppointmentListForm.Activate();
            childAppointmentListForm.BringToFront();
            childAppointmentListForm.Show();
        }

        /// <summary>
        /// Request and show the medical view form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_doclistview_Click(object sender, EventArgs e)
        {
            var childDoctorListForm = new DoctorListForm();
            _userLogs.MakeMovement("El usuario ingresó a Doctores Disponibles");
            childDoctorListForm.MdiParent = this;
            childDoctorListForm.WindowState = FormWindowState.Maximized;
            childDoctorListForm.Dock = DockStyle.Fill;
            pnl_container.Controls.Add(childDoctorListForm);
            pnl_container.Tag = childDoctorListForm;
            childDoctorListForm.Activate();
            childDoctorListForm.BringToFront();
            childDoctorListForm.Show();
        }

        /// <summary>
        /// Instantiate and display the turn management form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_apptmngmt_Click(object sender, EventArgs e)
        {
            var childAppointmentDMForm = new AppointmentDMForm();
            _userLogs.MakeMovement("El usuario ingresó a Gestión de Turnos");
            childAppointmentDMForm.MdiParent = this;
            childAppointmentDMForm.WindowState = FormWindowState.Maximized;
            childAppointmentDMForm.Dock = DockStyle.Fill;
            pnl_container.Controls.Add(childAppointmentDMForm);
            pnl_container.Tag = childAppointmentDMForm;
            childAppointmentDMForm.Activate();
            childAppointmentDMForm.BringToFront();
            childAppointmentDMForm.Show();
        }

        /// <summary>
        /// Instantiate and display the patient management form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_patientmngmt_Click(object sender, EventArgs e)
        {
            var childPatientADMForm = new PatientADMForm();
            _userLogs.MakeMovement("El usuario ingresó a Gestión de Pacientes");
            childPatientADMForm.MdiParent = this;
            childPatientADMForm.WindowState= FormWindowState.Maximized;
            childPatientADMForm.Dock = DockStyle.Fill;
            pnl_container.Controls.Add(childPatientADMForm);
            pnl_container.Tag = childPatientADMForm;
            childPatientADMForm.Activate();
            childPatientADMForm.BringToFront();
            childPatientADMForm.Show();
        }

        /// <summary>
        /// Closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_close_Click(object sender, EventArgs e)
        {
            _userLogs.MakeMovement("El usuario cerró la aplicación");
            Application.Exit();
        }

        /// <summary>
        /// Maximizes the window form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_maximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_maximize.Visible = false;
            btn_restore.Visible = true;
        }

        /// <summary>
        /// Restores the form window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_restore_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Normal;
            btn_restore.Visible = false;
            btn_maximize.Visible = true;

        }

        /// <summary>
        /// Minimizes the form window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Sets position of the window in cardinal axes when the click is held down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnl_title_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        /// <summary>
        /// Moves the window depending on the mouse position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnl_title_MouseMove(object sender, MouseEventArgs e)
        {
            if(m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        /// <summary>
        /// Sets the position of the window when the mouse click is released
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnl_title_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
    }
}
