using AbrilClinica.Entities.Utilities;
using Abril_Clinica.Models;
using AbrilClinica.Entities.Models;
using Google.Type;
using System.Collections.Generic;
using System.IO;
using AbrilClinica.Entities.Database;

namespace AbrilClinic.Presentation
{
    public partial class LogInForm : Form
    {
        
        
        // modifico, agrego y elimino datos de esas listas
        // termina el programa y reescribi esos archivos
        private List<User> _users;
        private User _user;
        private UserController _userController;

        public LogInForm()
        {
            InitializeComponent();
            _userController = new UserController();
            _users = new List<User>();
            _user = new User(); 
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

            _userController.CreateUsers();//Creo el Archivo y le cargo datos hardcodeados
            _users = _userController.GetUsers();// Leo el Archivo y cargo en listas los datos del Archivo
        }

        private void btn_logIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session.UserExits(tbx_username.Text, _users, out _user) && Session.IsCorrectPassword(_users, tbx_username.Text, tbx_password.Text))
                {
                    var principalMenu = new MenuForm(_user);
                    principalMenu.Show();
                    Hide();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo acceder. Reintente."); // no es lo mas optimo un message box
            }
        }

        private void btn_autofill_patient_Click(object sender, EventArgs e)
        {
            tbx_username.Text = "bdecima";
            tbx_password.Text = "coco123";
        }

        private void btn_autofill_admin_Click(object sender, EventArgs e)
        {
            tbx_username.Text = "msorio";
            tbx_password.Text = "cauro22";
        }
    }
}