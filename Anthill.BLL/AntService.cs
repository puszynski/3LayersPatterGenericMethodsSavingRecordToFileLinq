using Anthill.DAL.Repositories;
using Anthill.Models.BaseModels;
using Anthill.Models.DomainModels;
using Anthill.Models.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anthill.BLL
{
    public class AntService
    {
        readonly AntRepository _antRepo;

        public AntService() => _antRepo = new AntRepository();

        public void CreateAnt(QueenViewModel objVM)
        {
            // Validating age
            var ageValidator = new AgeValidator();
            bool isAgeCorrect = ageValidator.Validate(objVM.AntAge, objVM.AntType);

            if (isAgeCorrect == true)
            {
                // Mapping ViewModel -> DomainModel
                var objDM = new QueenDomainModel();

                objDM.Id = objVM.Id;
                objDM.AntName = objVM.AntName;
                objDM.AntType = objVM.AntType;
                objDM.AntAge = objVM.AntAge;

                this._antRepo.CreateAnt(objDM);
            }
        }
    }

    // Generic variant
    public class AntServiceGeneric<T> where T : AntBaseModel
    {
        readonly AntRepositoryGeneric<T> _antRepositoryGeneric;

        public AntServiceGeneric() => _antRepositoryGeneric = new AntRepositoryGeneric<T>();



        public void CreateAnt(T objGVM)
        {
            // mapping genericVM -> genericDM
            if (typeof(T) == typeof(QueenViewModel))
            {
                var objGDM = new QueenDomainModel();
                objGDM.Id = objGVM.Id;
                objGDM.AntName = objGVM.AntName;
                objGDM.AntType = objGVM.AntType;
                objGDM.AntAge = objGVM.AntAge;
            }
            else if (typeof(T) == typeof(MajorWorkerViewModel))
            {
                var objGDM = new MajorWorkerDomainModel();
                objGDM.Id = objGVM.Id;
                objGDM.AntName = objGVM.AntName;
                objGDM.AntType = objGVM.AntType;
                objGDM.AntAge = objGVM.AntAge;
            }
            else if (typeof(T) == typeof(MinorWorkerViewModel))
            {
                var objGDM = new MinorWorkerDomainModel();
                objGDM.Id = objGVM.Id;
                objGDM.AntName = objGVM.AntName;
                objGDM.AntType = objGVM.AntType;
                objGDM.AntAge = objGVM.AntAge;
            }
            else if (typeof(T) == typeof(MaleViewModel))
            {
                var objGDM = new MaleDomainModel();
                objGDM.Id = objGVM.Id;
                objGDM.AntName = objGVM.AntName;
                objGDM.AntType = objGVM.AntType;
                objGDM.AntAge = objGVM.AntAge;
            }
            else
            {
                throw new Exception("Something is wrong with mapping");
            }


            this._antRepositoryGeneric.CreateAnt(objGVM);
        }
    }
}
