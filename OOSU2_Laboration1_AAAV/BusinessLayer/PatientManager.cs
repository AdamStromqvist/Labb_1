﻿using OOSU2_Laboration1_AAAV.DataLayer.DataLayer;
using OOSU2_Laboration1_AAAV.EntetiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSU2_Laboration1_AAAV.BusinessLayer
{
    //-----------------------------------------------------------------------------------------------------------------------
    //PatientManager which includes Registerpatient, UpdatePatient and RemovePatient.
    //-----------------------------------------------------------------------------------------------------------------------
    public class PatientManager
    {
        private readonly UnitOfWork unitOfWork;

        public PatientManager(UnitOfWork unitOfWork)
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

        public void RegisterPatient(Patient patient)
        {
            unitOfWork.PatientRepository.Add(patient);
            unitOfWork.Save();
        }

        public void UpdatePatient(Patient updatedPatient, int patientID)
        {
            var existingPatient = unitOfWork.PatientRepository.FirstOrDefault(p => p.PatientID == patientID);
            if (existingPatient != null)
            {
                existingPatient.PatientID = updatedPatient.PatientID;
                existingPatient.PatientName = updatedPatient.PatientName;
                existingPatient.SocialSecurityNr = updatedPatient.SocialSecurityNr;
                existingPatient.Address = updatedPatient.Address;
                existingPatient.PhoneNr = updatedPatient.PhoneNr;
                existingPatient.EmailAddress = updatedPatient.EmailAddress;
                unitOfWork.Save();
            }
        }

        public bool RemovePatient(int patientID)
        {
            var patientToRemove = unitOfWork.PatientRepository.FirstOrDefault(p => p.PatientID == patientID);
            if (patientToRemove != null)
            {
                unitOfWork.PatientRepository.Remove(patientToRemove);
                unitOfWork.Save();
                return true;
            }
            return false;
        }
    }
}
