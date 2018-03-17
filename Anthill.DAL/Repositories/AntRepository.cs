using Anthill.Models.BaseModels;
using Anthill.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Anthill.DAL.Repositories
{
    public class AntRepository
    {
        const string filePath = @"C:\Users\puszy\OneDrive\Dokumenty\C#\Anthill3LayersPatterWithGeneric\Anthill.DAL\datafile.txt";

        public void CreateAnt(QueenDomainModel objDM)
        {
            #region using SQLite & Entity Framework

            #endregion

            #region using text file
            try
            {
                List<string> output = File.ReadAllLines(filePath).ToList();
                output.Add($"{objDM.Id}, {objDM.AntName}, {objDM.AntType}, {objDM.AntAge}");
                File.WriteAllLines(filePath, output);

            }
            catch (Exception)
            {
                throw;
            }
            #endregion
        }
    }



    // Generic variant
    public class AntRepositoryGeneric<T> where T : AntBaseModel
    {
        const string filePath = @"C:\Users\puszy\OneDrive\Dokumenty\C#\Anthill3LayersPatterWithGeneric\Anthill.DAL\datafile.txt";

        public void CreateAnt(T objDM)
        {
            #region using SQLite & Entity Framework

            #endregion

            #region using text file
            try
            {
                List<string> output = File.ReadAllLines(filePath).ToList();
                output.Add($"{objDM.Id}, {objDM.AntName}, {objDM.AntType}, {objDM.AntAge}");
                File.WriteAllLines(filePath, output);

            }
            catch (Exception)
            {
                throw;
            }
            #endregion
        }
    }
}
