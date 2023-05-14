using AbrilClinica.Entities.Utilities;
using Abril_Clinica.Models;
using AbrilClinica.Entities.Models;
using Google.Type;
using System.Collections.Generic;
using System.IO;
using AbrilClinica.Entities.Database;
using Microsoft.VisualBasic.ApplicationServices;
using System.Linq.Expressions;
using User = Abril_Clinica.Models.User;

namespace AbrilClinic.Presentation
{
    public partial class LogInForm : Form
    {
        private UserController _userController;
        private List<User> _users;
        private User _user;

        public LogInForm()
        {
            InitializeComponent();
            _userController = new UserController();
            _users = new List<User>();
            _user = new User(); 
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {    
            _userController.CreateUsers();
            _users = _userController.GetUsers();
        }

        private void btn_logIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session.UserExits(tbx_username.Text, _users, out _user) && Session.IsCorrectPassword(_user, tbx_password.Text))
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