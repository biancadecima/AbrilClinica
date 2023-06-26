using AbrilClinica.Entities.Utilities;
using Abril_Clinica.Models;
using Google.Type;
using System.Collections.Generic;
using System.IO;
using AbrilClinica.Entities.Database;
using Microsoft.VisualBasic.ApplicationServices;
using System.Linq.Expressions;
using User = Abril_Clinica.Models.User;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using AbrilClinica.Entities.Logs;
using static AbrilClinica.Entities.Logs.UserLogs;

namespace AbrilClinic.Presentation
{
    public partial class LogInForm : Form
    {
        private PatientController _patientController;
        private AdminController _adminController; 
        private List<Patient> _patients;
        private List<Admin> _admins;
        private User _user;
        private UserLogs _userLogs;

        /// <summary>
        /// initializes the log in form, the user list, the user controller, and a user
        /// </summary>
        public LogInForm()
        {
            InitializeComponent();
            _patientController = new PatientController();
            _adminController = new AdminController();
            _patients = new List<Patient>();
            _admins = new List<Admin>();
            _user = new User(); 
            _userLogs = new UserLogs();
        }

        /// <summary>
        /// subscribes to the event logs and loads the list of patients and admins
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void LogInForm_Load(object sender, EventArgs e)
        {    
            _admins = await _adminController.GetAdmins();
            _patients = await _patientController.GetPatients();
            _userLogs.Movement += UserLogs.User_Movement;
            pbx_show.BringToFront();
            tbx_password.PasswordChar = '*';
        }

        /// <summary>
        /// Validates the user input and if it is correct, instantiates the menu form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_logIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session.UserExists(tbx_username.Text, _patients, _admins, out _user) && Session.IsCorrectPassword(_user, tbx_password.Text))
                {
                    _userLogs.MakeMovement("El usuario ingreso en la aplicacion");
                    var principalMenu = new MenuForm(_user);
                    principalMenu.Show();
                    Hide(); 
                }
            }
            catch(Exception)
            {
                MessageBox.Show("No se pudo acceder. Reintente.");
            }
        }

        /// <summary>
        /// Fill in the textboxes with data from a patient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_autofill_patient_Click(object sender, EventArgs e)
        {
            tbx_username.Text = "bdecima";
            tbx_password.Text = "coco123";
        }

        /// <summary>
        /// Fill in the textboxes with data from an admin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_autofill_admin_Click(object sender, EventArgs e)
        {
            tbx_username.Text = "msorio";
            tbx_password.Text = "cauro22";
        }

        /// <summary>
        /// Shows password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbx_show_Click(object sender, EventArgs e)
        {
            pbx_hide.BringToFront();
            tbx_password.PasswordChar = '\0';
        }

        /// <summary>
        /// Hides password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbx_hide_Click(object sender, EventArgs e)
        {
            pbx_show.BringToFront();
            tbx_password.PasswordChar = '*';
        }
 
    }
}