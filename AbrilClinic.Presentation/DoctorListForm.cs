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

        /// <summary>
        /// initialize the form, instantiate a list of admins and the admin controller
        /// </summary>
        public DoctorListForm()
        {
            InitializeComponent();
            _adminController = new AdminController();
            _admins = new List<Admin>();
        }

        /// <summary>
        /// load the form, load a list with the admins and update the datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoctorListForm_Load(object sender, EventArgs e)
        {
            _adminController.CreateAdmins();
            _admins = _adminController.GetAdmins();
            ActualizeDataGrid(_admins);
        }

        /// <summary>
        /// update the datagrid with the list of admins
        /// </summary>
        /// <param name="admins"></param>
        public void ActualizeDataGrid(List<Admin> admins)
        {
            dgv_doctors.DataSource = null;
            dgv_doctors.DataSource = admins;
            this.dgv_doctors.Columns["Password"].Visible = false;
            this.dgv_doctors.Columns["Username"].Visible = false;
        }
    }
}
