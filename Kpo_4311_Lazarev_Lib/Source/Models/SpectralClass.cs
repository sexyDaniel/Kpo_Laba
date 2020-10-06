using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo_4311_Lazarev_lib
{
    public class SpectralClass
    {

        public string SpectralClassName { get; set; }
        public double MassOfTheSun { get; set; }
        public double Part { get; set; }
        public long Count { get; set; }

        public SpectralClass()
        {
            SpectralClassName = "";
            MassOfTheSun = 0;
            Part = 0;
            Count = 0;
        }
    }
}
