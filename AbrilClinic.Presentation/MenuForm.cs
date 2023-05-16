using Abril_Clinica.Models;
using AbrilClinica.Entities.Database;
using AbrilClinica.Entities.Models;
using AbrilClinica.UI;
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
        private MenuForm()
        {
            InitializeComponent();
            _adminController= new AdminController();
            _patientController= new PatientController();
        }

        public MenuForm(User user):this()
        {
            _user = user;

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            if (Session.IsAnAdminSession(_user))
            {
                // es admin
                btn_appointment.Visible = false;
                btn_apptview.Visible = false;
                btn_doclistview.Visible = false;
                _adminController.CreateAdmins();
                _admin = _adminController.GetAdminByUsername(_user.Username);
            }
            else
            {
                //es paciente
                btn_apptmngmt.Visible = false;
                btn_patientmngmt.Visible = false;
                _patientController.CreatePatients();
                _patient = _patientController.GetPatientByUsername(_user.Username);
            }

        }

        private void btn_appointment_Click(object sender, EventArgs e)
        {
            var childAppointmentForm = new AppointmentForm(_patient);
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

        private void btn_apptview_Click(object sender, EventArgs e)
        {
            var childAppointmentListForm = new AppointmentListForm(_patient);
            childAppointmentListForm.MdiParent = this;
            childAppointmentListForm.WindowState = FormWindowState.Maximized;
            childAppointmentListForm.Dock = DockStyle.Fill;
            pnl_container.Controls.Add(childAppointmentListForm);
            pnl_container.Tag = childAppointmentListForm;
            childAppointmentListForm.Activate();
            childAppointmentListForm.BringToFront();
            childAppointmentListForm.Show();
        }

        private void btn_doclistview_Click(object sender, EventArgs e)
        {
            var childDoctorListForm = new DoctorListForm();
            childDoctorListForm.MdiParent = this;
            childDoctorListForm.WindowState = FormWindowState.Maximized;
            childDoctorListForm.Dock = DockStyle.Fill;
            pnl_container.Controls.Add(childDoctorListForm);
            pnl_container.Tag = childDoctorListForm;
            childDoctorListForm.Activate();
            childDoctorListForm.BringToFront();
            childDoctorListForm.Show();
        }

        private void btn_apptmngmt_Click(object sender, EventArgs e)
        {
            var childAppointmentDMForm = new AppointmentDMForm();
            childAppointmentDMForm.MdiParent = this;
            childAppointmentDMForm.WindowState = FormWindowState.Maximized;
            childAppointmentDMForm.Dock = DockStyle.Fill;
            pnl_container.Controls.Add(childAppointmentDMForm);
            pnl_container.Tag = childAppointmentDMForm;
            childAppointmentDMForm.Activate();
            childAppointmentDMForm.BringToFront();
            childAppointmentDMForm.Show();
        }

        private void btn_patientmngmt_Click(object sender, EventArgs e)
        {
            var childPatientADMForm = new PatientADMForm();
            childPatientADMForm.MdiParent = this;
            childPatientADMForm.WindowState= FormWindowState.Maximized;
            childPatientADMForm.Dock = DockStyle.Fill;
            pnl_container.Controls.Add(childPatientADMForm);
            pnl_container.Tag = childPatientADMForm;
            childPatientADMForm.Activate();
            childPatientADMForm.BringToFront();
            childPatientADMForm.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_maximize.Visible = false;
            btn_restore.Visible = true;
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Normal;
            btn_restore.Visible = false;
            btn_maximize.Visible = true;

        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    
    }
}
