using Anthill.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anthill.BLL
{
    public class AgeValidator
    {
        public bool Validate(int age, AntType type)
        {

            if (type == AntType.Queen && age < 35)
            {
                return true;
            }
            else if (age < 5)
            {
                return true;
            }
            else return false;
        }
    }
}
