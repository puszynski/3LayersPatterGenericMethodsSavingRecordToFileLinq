using Anthill.BLL;
using Anthill.Models.BaseModels;
using Anthill.Models.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Anthill.UI
{
    class Program
    {
        static AntController antController = new AntController();
        static AntControllerGeneric<QueenViewModel> antGenericController = new AntControllerGeneric<QueenViewModel>();

        static void Main(string[] args)
        {
            var queenAkasha = new QueenViewModel();
            queenAkasha.Id = 6;
            queenAkasha.AntName = "Akasha4";
            queenAkasha.AntType = Models.BaseModels.AntType.Queen;
            queenAkasha.AntAge = 7;

            // Adding record without generic
            antController.CreateAnt(queenAkasha);


            var queenDiana = new QueenViewModel();
            queenDiana.Id = 7;
            queenDiana.AntName = "Diana";
            queenDiana.AntType = AntType.Queen;
            queenDiana.AntAge = 18;

            // Adding record with generic
            antGenericController.CreateAnt(queenDiana);

        }


    }

    // Non generic case:
    public class AntController
    {
        readonly AntService _antService;

        public AntController() => _antService = new AntService();


        public void CreateAnt(QueenViewModel objVM)
        {
            this._antService.CreateAnt(objVM);
        }
    }


    // GENERIC variant
    public class AntControllerGeneric<T> where T : AntBaseModel
    {
        readonly AntServiceGeneric<T> _antServiceGeneric;

        public AntControllerGeneric() => _antServiceGeneric = new AntServiceGeneric<T>();

        public void CreateAnt(T objVM)
        {
            this._antServiceGeneric.CreateAnt(objVM);
        }
    }
}
