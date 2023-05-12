using Abril_Clinica.Models;
using AbrilClinica.Entities.Models;
using AbrilClinica.Entities.Utilities;
using Google.Type;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DateTime = System.DateTime;

namespace AbrilClinica.UI
{
    public partial class AppointmentForm : Form
    {
        private User _user;
        private DateTime selectectedDate;
        private Random _idGenerator = new Random();

        // private Patient _patient;
        public AppointmentForm()
        {
            InitializeComponent();
        }

        public AppointmentForm(User user): this()
        {
            _user = user;
            //_patient = patient;
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            this.dtp_appntDate.MinDate = new System.DateTime(2023, 5, 5, 0, 0, 0, 0);
            this.dtp_appntDate.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            
        }

        private void btn_request_Click(object sender, EventArgs e)
        {
            Patient patient = (Patient)_user;
            //comprobar que el dni ingresado coincida con el dni del paciente
            selectectedDate = dtp_appntDate.Value;
            if(Validator.IsDni(txb_dniPatient.Text,out int dni) && Validator.IsString(cbx_specialField.GetItemText(cbx_specialField.SelectedItem)))
            {
                //sin _idDoctor
                var newAppointment = new Appointment(_idGenerator.Next(100, 500), dni, cbx_specialField.GetItemText(cbx_specialField.SelectedItem), selectectedDate);
                //tendria que agregarlo a la base de datos
                MessageBox.Show("Se agendó el turno exitosamente.");
            }
            else
            {
                MessageBox.Show("No se pudo solicitar el turno. Reintente.");
            }
           
        }

        
    }
}
