using Abril_Clinica.Models;
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
        private MenuForm()
        {
            InitializeComponent();
            // se inicializa todo en el contrustror, inclusive un objeto que queramos usar 
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
                btn_appointment.Visible = false;
                btn_apptview.Visible = false;
                btn_doclistview.Visible = false;
            }
            else
            {
                btn_apptmngmt.Visible = false;
                btn_patientmngmt.Visible = false;
            }
          
        }

        private void btn_appointment_Click(object sender, EventArgs e)
        {
            Patient patient = (Patient)_user; // esta bien esto?
            var childAppointmentForm = new AppointmentForm(patient);
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
            Patient patient = (Patient)_user; // esta bien esto?
            var childAppointmentListForm = new AppointmentListForm(patient);
            childAppointmentListForm.MdiParent = this;
            childAppointmentListForm.WindowState = FormWindowState.Maximized;

            
            childAppointmentListForm.Dock = DockStyle.Fill;
            pnl_container.Controls.Add(childAppointmentListForm);
            pnl_container.Tag = childAppointmentListForm;
            childAppointmentListForm.Activate();
            childAppointmentListForm.BringToFront();
            childAppointmentListForm.Show();
        }

        //private void sacarTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    var child = new AppointmentForm();
        //    child.MdiParent = this;
        //    child.WindowState = FormWindowState.Minimized;
        //    child.Show();
        //}

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
