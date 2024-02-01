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
    //DiagnosisManager which only includes RegisterDiagnosis to short down the application a little bit!
    //-----------------------------------------------------------------------------------------------------------------------
    public class DiagnosisManager
    {
        private readonly UnitOfWork unitOfWork;

        public DiagnosisManager(UnitOfWork unitOfWork)
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

        public void RegisterDiagnosis(Diagnosis diagnosis)
        {
            unitOfWork.DiagnosisRepository.Add(diagnosis);
            unitOfWork.Save();
        }
    }
}
