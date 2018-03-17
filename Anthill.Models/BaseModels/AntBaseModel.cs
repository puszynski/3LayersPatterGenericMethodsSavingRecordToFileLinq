using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anthill.Models.BaseModels
{
    public enum AntType
    {
        Queen,
        Male,
        MajorWorker,
        MinorWorker
    }


    public class AntBaseModel
    {
        public int Id;
        public string AntName { get; set; }
        public AntType AntType { get; set; }
        public int AntAge { get; set; }

    }
}
