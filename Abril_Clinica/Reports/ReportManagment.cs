﻿using Abril_Clinica.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrilClinica.Entities.Reports
{
    public class ReportManagment
    {
        public delegate void MakeReport<T>(List<T> list);

        public static string SerializeObject<T>(List<T> list)
        {
            string jsonData = JsonConvert.SerializeObject(list, Formatting.Indented);
            return jsonData;
        }
    }
}
