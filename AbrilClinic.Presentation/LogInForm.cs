using AbrilClinica.Entities.Utilities;
using Abril_Clinica.Models;
using AbrilClinica.Entities.Models;

namespace AbrilClinic.Presentation
{
    public partial class LogInForm : Form
    {
        private List<User> _users;

        public LogInForm()
        {
            InitializeComponent();

            _users = new List<User>();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            Harcoder.HarcodeUsers(_users);
        }

        private void btn_logIn_Click(object sender, EventArgs e)
        {
            var user = new User();
            if (Session.UserExits(tbx_username.Text, _users, out user) && Session.IsCorrectPassword(_users, tbx_username.Text, tbx_password.Text))
            {
                if(user is not null)
                {
                    var principalMenu = new MenuForm(user);
                    principalMenu.Show();
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("No se pudo acceder. Reintente.");
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