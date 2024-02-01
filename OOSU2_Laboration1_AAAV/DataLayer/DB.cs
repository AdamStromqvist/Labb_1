using OOSU2_Laboration1_AAAV.EntetiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSU2_Laboration1_AAAV.DataLayer
{
    //-------------------------------------------
    //Database, nothing mroe to say?!?
    //-------------------------------------------
    public class DB
    {
        public List<Patient> Patients { get; set; }
        public List<DoctorAppointment> DoctorAppointments { get; set; }
        public List<Diagnosis> Diagnoses { get; set; }
        public List<MedicinePrescription> MedicinePrescriptions { get; set; }

        public DataLayer.UnitOfWork UnitOfWork
        {
            get => default;
            set
            {
            }
        }

        public DB()
        {
            Patients = new List<Patient>();
            DoctorAppointments = new List<DoctorAppointment>();
            Diagnoses = new List<Diagnosis>();
            MedicinePrescriptions = new List<MedicinePrescription>();
        }
    }
}
