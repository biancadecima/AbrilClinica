using AbrilClinica.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AbrilClinica.UI
{
    public partial class AddForm : Form
    {
        private Appointment _newAppointment;// instancio un objeto appointment
        public Appointment NewAppointment{ get => _newAppointment; } // hago el getter (encapsulamiento) del appointment instanciado

        public AddForm()
        {
            InitializeComponent();
            
        }

        //private void btn_add_Click(object sender, EventArgs e)/*boton de confirmar/ acptar el add*/
        //{
        //    _newAppointment = new Appointment(/*pongo los textbox.Text introducidos luego de pasar por una validacion*/);
        //    DialogResult= DialogResult.OK;
        //    //estaria vueno volver al appointment list form luego del dialog result
        //}
    }
}
