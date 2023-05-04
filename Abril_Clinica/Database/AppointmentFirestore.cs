using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrilClinica.Entities.Database
{
    [FirestoreData]
    public class AppointmentFO
    {
        [FirestoreProperty]
        public int Id { get; set; }

        [FirestoreProperty]
        public int DniPatient { get; set; }

        [FirestoreProperty]
        public string SpecialField { get; set; }

        [FirestoreProperty]
        public DateTime Date { get; set; }

    }
    //Program.cs
}
