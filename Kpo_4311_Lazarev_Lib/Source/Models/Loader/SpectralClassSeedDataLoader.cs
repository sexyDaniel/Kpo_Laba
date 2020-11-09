using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo_4311_Lazarev_lib
{
    public class SpectralClassSeedDataLoader : IRepositoryLoader
    {
        public string FileName { get; set ; }
        public List<SpectralClass> StarsList { get; private set; }
        public LoadStatus Status { get; private set; }= LoadStatus.None;

        public SpectralClassSeedDataLoader()
        {
            StarsList = new List<SpectralClass>();
        }

        public void Execute()
        {
            StarsList.Add(
               new SpectralClass
               {
                   SpectralClassName = "O",
                   MassOfTheSun = 32,
                   Count = 55000,
                   Part = 0.00002
               });
            StarsList.Add(
                new SpectralClass
                {
                    SpectralClassName = "F",
                    MassOfTheSun = 1.25,
                    Count = 12000000000,
                    Part = 2.9
                });
            StarsList.Add(
               new SpectralClass
               {
                   SpectralClassName = "D",
                   MassOfTheSun = 1.7,
                   Count = 12000000,
                   Part = 1.2
               });
            Status = LoadStatus.Success;
        }
    }
}
