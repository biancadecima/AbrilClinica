using AbrilClinica.Entities.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrilClinica.Entities.DataManagment
{
    // aca yo haria un add / save / delete / etc. ver clase
    public class AppointmentData : Connection
    {
        public AppointmentData(string collection, string document) : base(collection, document)
        {

        }
    }
}
