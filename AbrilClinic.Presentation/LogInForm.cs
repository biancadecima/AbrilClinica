using AbrilClinica.Entities.Utilities;
using Abril_Clinica.Models;

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
            Harcoder.HarcodeUsers(_users);// comienza con usuarios hardcodeados
        }
    }
}