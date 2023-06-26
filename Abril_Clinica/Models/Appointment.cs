using Abril_Clinica.Models;
using AbrilClinica.Entities.Utilities;
using System.ComponentModel;
using System.Data;
using System.Text;

namespace AbrilClinica.Entities.Models
{
    public class Appointment : Parser
    {
        private int _id;
        private int _dniPatient;
        private string _specialField;
        private DateTime _date;

        [Browsable(false)]
        public int Id { get => _id; set => _id = value; }
        public int DniPatient { get => _dniPatient; set => _dniPatient = value; }
        public string SpecialField { get => _specialField; set => _specialField = value; }
        public DateTime Date { get => _date; set => _date = value; }

        public Appointment() { }

        /// <summary>
        /// initialize an appointment with data
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dniPatient"></param>
        /// <param name="specialField"></param>
        /// <param name="date"></param>
        public Appointment(int id, int dniPatient, string specialField, DateTime date)
        {
            _id = id;
            _dniPatient = dniPatient;
            _specialField = specialField;
            _date = date;
        }

        /// <summary>
        /// convert a string to a appointment
        /// </summary>
        /// <param name="line"></param>
        public static explicit operator Appointment(/*string line*/ DataRow row)
        {
            var id = Convert.ToInt32(row["Id"].ToString());
            var dniPatient = Convert.ToInt32(row["DniPaciente"].ToString());
            var specialField = row["Especialidad"].ToString();
            var date = DateTime.Parse(row["Fecha"].ToString());

            Appointment appt = new Appointment(id, dniPatient, specialField, date);

            return appt;
        }

        /// <summary>
        /// convert appointment to string
        /// </summary>
        /// <returns></returns>
        public override string ObjectToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Id},{DniPatient},{SpecialField},{Date}");
            return sb.ToString();
        }

       
        /// <summary>
        /// creates new unique id
        /// </summary>
        /// <param name="appointments"></param>
        /// <returns></returns>
        public static int NewIdAppointment(List<Appointment> appointments)
        {
            Random idGenerator = new Random();
            int id = idGenerator.Next(1, 500);
            foreach(Appointment appointment in appointments)
            {
                if(appointment.Id == id)
                {
                    id = NewIdAppointment(appointments);
                } 
            }
            return id;
        }
    }
}
