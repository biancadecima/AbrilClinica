using Abril_Clinica.Models;
using System.ComponentModel;
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
        public int Id { get => _id;}
        public int DniPatient { get => _dniPatient;}
        public string SpecialField { get => _specialField; set => _specialField = value; }
        public DateTime Date { get => _date; set => _date = value; }

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
        public static explicit operator Appointment(string line)
        {
            string separator = ",";
            string[] row = line.Split(separator);

            int id = Convert.ToInt32(row[0]);
            int dniPatient = Convert.ToInt32(row[1]);
            string specialField = row[2];
            DateTime date = DateTime.Parse(row[3]);
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
        /// parse into an appointment
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public override Parser Parse(string line)
        {
            Appointment appointment = (Appointment)line;
            return appointment;
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
