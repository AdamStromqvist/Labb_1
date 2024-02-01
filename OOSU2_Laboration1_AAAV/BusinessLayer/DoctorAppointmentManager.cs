using OOSU2_Laboration1_AAAV.DataLayer.DataLayer;
using OOSU2_Laboration1_AAAV.EntetiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSU2_Laboration1_AAAV.BusinessLayer
{
    //-----------------------------------------------------------------------------------------------------------------------
    //DoctorAppointmentManager which includes BookDoctorAppointment, UpdateDoctorAppointment and RemoveDoctorAppointment.
    //-----------------------------------------------------------------------------------------------------------------------
    public class DoctorAppointmentManager
    {
        private readonly UnitOfWork unitOfWork;

        public DoctorAppointmentManager(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        internal PresentationLayer.Program Program
        {
            get => default;
            set
            {
            }
        }

        public void BookDoctorAppointment(DoctorAppointment appointment)
        {
            unitOfWork.DoctorAppointmentRepository.Add(appointment);
            unitOfWork.Save();
        }

        public void UpdateDoctorAppointment(DoctorAppointment updatedDoctorAppointment, int doctorAppointmentID)
        {
            var existingDoctorAppointment = unitOfWork.DoctorAppointmentRepository.FirstOrDefault(p => p.DoctorAppointmentID == doctorAppointmentID);
            if (existingDoctorAppointment != null)
            {
                existingDoctorAppointment.DoctorAppointmentID = updatedDoctorAppointment.DoctorAppointmentID;
                existingDoctorAppointment.PatientID = updatedDoctorAppointment.PatientID;
                existingDoctorAppointment.Date = updatedDoctorAppointment.Date;
                existingDoctorAppointment.Time = updatedDoctorAppointment.Time;
                existingDoctorAppointment.Purpose = updatedDoctorAppointment.Purpose;
                existingDoctorAppointment.EmploymentID = updatedDoctorAppointment.EmploymentID;
                unitOfWork.Save();
            }
        }

        public DoctorAppointment GetDoctorAppointmentByDoctorAppointmentID(int doctorAppointmentID)
        {
            return unitOfWork.DoctorAppointmentRepository.FirstOrDefault(appointment => appointment.DoctorAppointmentID == doctorAppointmentID);
        }

        public bool RemoveDoctorAppointment(int doctorAppointmentID)
        {
            var appointmentToRemove = unitOfWork.DoctorAppointmentRepository.FirstOrDefault(appointment => appointment.DoctorAppointmentID == doctorAppointmentID);
            if (appointmentToRemove != null)
            {
                unitOfWork.DoctorAppointmentRepository.Remove(appointmentToRemove);
                unitOfWork.Save();
                return true;
            }
            return false;
        }
    }
}
