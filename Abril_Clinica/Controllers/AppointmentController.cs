﻿using Abril_Clinica.Models;
using AbrilClinica.Entities.Handlers;
using AbrilClinica.Entities.Models;
using AbrilClinica.Entities.Reports;
using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace AbrilClinica.Entities.Database
{
    public class AppointmentController
    {
        private AppointmentHandler _appointmentHandler;

        /// <summary>
        /// instance the database
        /// </summary>
        public AppointmentController()
        {
            _appointmentHandler = new AppointmentHandler();
        }

        /// <summary>
        /// reads the database and returns a list of appointments
        /// </summary>
        /// <returns></returns>
        public async Task<List<Appointment>> GetAppointments()
        {
            return await _appointmentHandler.GetAll();
        }

        /// <summary>
        /// create a list with the appointments of the same ID
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        public async Task<List<Appointment>> GetAppointmentsByDniPatient(int dni)
        {
            return await _appointmentHandler.GetByDniPatient(dni);
        } 

        /// <summary>
        /// Write appointment to a database
        /// </summary>
        /// <param name="appointments"></param>
        public async Task Add(Appointment appointment)
        {
            await _appointmentHandler.Add(appointment);
        }

        public async Task Update(Appointment appointment)
        {
            await _appointmentHandler.Update(appointment);
        }

        public async Task Delete(Appointment appointment)
        {
            await _appointmentHandler.Delete(appointment.Id);
        }

        
    }
}