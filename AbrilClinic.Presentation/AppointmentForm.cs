using Abril_Clinica.Models;
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
    public partial class AppointmentForm : Form
    {
        private Patient _patient;
        public AppointmentForm()
        {
            InitializeComponent();
        }

        public AppointmentForm(Patient patient): this()
        {
            _patient = patient;
        }


    }
}
