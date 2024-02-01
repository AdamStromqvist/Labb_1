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
    //MedicinePrescriptionManager which only includes RegisterMedicinePrescription to short down the application a little bit!
    //-----------------------------------------------------------------------------------------------------------------------
    public class MedicinePrescriptionManager
    {
        private readonly UnitOfWork unitOfWork;

        public MedicinePrescriptionManager(UnitOfWork unitOfWork)
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

        public void RegisterMedicinePrescription(MedicinePrescription prescription)
        {
            unitOfWork.MedicinePrescriptionRepository.Add(prescription);
            unitOfWork.Save();
        }
    }
}
