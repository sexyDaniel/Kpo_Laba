using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo_4311_Lazarev_lib
{
    public interface ISpectralClassRepository
    {
        List<SpectralClass> StarsList { get; set; }
        void Add(SpectralClass spectralClass);
        void Delete(string spectralClassName);
        void Edit(SpectralClass spectralClass);
    }
}
