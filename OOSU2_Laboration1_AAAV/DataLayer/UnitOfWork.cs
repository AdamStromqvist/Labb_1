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
        {
            private readonly DB db;

            public UnitOfWork()
            {
                db = new DB();
            }

            public Repository<Patient> PatientRepository => new Repository<Patient>(db.Patients);
            public Repository<DoctorAppointment> DoctorAppointmentRepository => new Repository<DoctorAppointment>(db.DoctorAppointments);
            public Repository<Diagnosis> DiagnosisRepository => new Repository<Diagnosis>(db.Diagnoses);
            public Repository<MedicinePrescription> MedicinePrescriptionRepository => new Repository<MedicinePrescription>(db.MedicinePrescriptions);

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

            public void Save()
            {
                // No additional logic required if you are already saving to in-memory database (the DB class).
            }
        }
    }
}