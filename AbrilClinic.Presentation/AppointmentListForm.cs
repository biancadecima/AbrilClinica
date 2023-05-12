using Abril_Clinica.Models;
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
    public partial class AppointmentListForm : Form
    {
        private List<Appointment> _appointments;
        private Patient _patient;

        public AppointmentListForm()
        {
            InitializeComponent();
            _appointments = new List<Appointment>();
        }

        public AppointmentListForm(Patient patient)
        {
             _patient = patient;
        }

        private void AppointmentListForm_Load(object sender, EventArgs e)
        {
            _appointments = Harcoder.HardcodeAppointment();
            ActualizeDataGrid(_appointments); 
        }

        public void ActualizeDataGrid(List<Appointment> appointments)
        {
            dgv_appointment.DataSource = null;
            dgv_appointment.DataSource = appointments;// establece que una coleccion sea su base de datos
        }



        //public void btnAdd_Click(object sender, EventArgs e)
        //{
        //    var addAppointment = new AddForm();
        //    if (addAppointment.ShowDialog() == DialogResult.OK)// significa que el producto pudo darese de alta
        //    {
        //        appointments.Add(addAppointment.NewAppointment);
        //        ActualizeDataGrid(appointments);
        //    }
        //    else
        //    {
        //        MessageBox.Show("El turno no pudo darse de alta");
        //    }
        //}
        //private void btnShow_Click(object sender, EventArgs e)
        //{
        //    Appointment appointment = (Appointment)dgv_appointment.SelectedRows[0].DataBoundItem;
        //    MessageBox.Show(appointment.ShowAppointment());
        //}
    }
}
