using Abril_Clinica.Models;
using AbrilClinica.Entities.Database;
using AbrilClinica.Entities.Models;
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
    public partial class DoctorListForm : Form
    {
        private AdminController _adminController;
        private List<Admin> _admins;
        public DoctorListForm()
        {
            InitializeComponent();
            _adminController = new AdminController();
            _admins = new List<Admin>();
        }

        private void DoctorListForm_Load(object sender, EventArgs e)
        {
            _admins = _adminController.GetAdmins();
            ActualizeDataGrid(_admins);
        }

        public void ActualizeDataGrid(List<Admin> admins)
        {
            dgv_doctors.DataSource = null;
            dgv_doctors.DataSource = admins;
        }
    }
}
