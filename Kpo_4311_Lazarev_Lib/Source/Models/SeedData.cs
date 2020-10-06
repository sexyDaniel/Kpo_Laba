using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo_4311_Lazarev_lib
{
    public class SeedData:IStarsListLoader
    {
        public List<SpectralClass> StarsList { get; private set; }
        public SeedData()
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
        }
    } 
}