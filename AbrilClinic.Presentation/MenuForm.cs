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
        public MenuForm()
        {
            InitializeComponent();
            // se inicializa todo en el contrustro, inclusive un objeto que queramos usar 
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void sacarTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = new AppointmentForm();
            child.MdiParent = this;
            child.WindowState = FormWindowState.Minimized;
            child.Show();
        }
    }
}
