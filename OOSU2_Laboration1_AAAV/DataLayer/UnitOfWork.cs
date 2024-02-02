using OOSU2_Laboration1_AAAV.EntetiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSU2_Laboration1_AAAV.DataLayer
{
    namespace DataLayer
    {
        //-----------------------------------------------------------------------------------------------------------------------
        //UnityOfWork connects a specifik entity with the Generic Repository and the Database (DB).
        //-----------------------------------------------------------------------------------------------------------------------
        public class UnitOfWork
        {    // Private field to hold the database context
            private readonly DB db;
            // Constructor to initialize the database context
            public UnitOfWork()
            {
                db = new DB();
            }

            public Repository<Patient> PatientRepository => new Repository<Patient>(db.Patients); // Property to get a repository for patient entities
            public Repository<DoctorAppointment> DoctorAppointmentRepository => new Repository<DoctorAppointment>(db.DoctorAppointments); // Property to get a repository for DoctorAppointments
            public Repository<Diagnosis> DiagnosisRepository => new Repository<Diagnosis>(db.Diagnoses); // Property to get a repository for Diagnosis
            public Repository<MedicinePrescription> MedicinePrescriptionRepository => new Repository<MedicinePrescription>(db.MedicinePrescriptions); // Property to get a repository for MedicinePrescriptions
            // A placeholder properties for various managers in the BusinessLayer
            public BusinessLayer.PatientManager PatientManager
            {
                get => default;
                set
                {
                }
            }

            public BusinessLayer.DiagnosisManager DiagnosisManager
            {
                get => default;
                set
                {
                }
            }

            public BusinessLayer.DoctorAppointmentManager DoctorAppointmentManager
            {
                get => default;
                set
                {
                }
            }

            public BusinessLayer.MedicinePrescriptionManager MedicinePrescriptionManager
            {
                get => default;
                set
                {
                }
            }
            // Method to save changes to the Database
            public void Save()
            {
                // No additional logic required if you are already saving to in-memory database (the DB class).
            }
        }
    }
}
