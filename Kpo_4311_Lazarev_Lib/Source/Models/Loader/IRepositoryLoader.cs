using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo_4311_Lazarev_lib
{
    public interface IRepositoryLoader
    {
        string FileName { get; set; }
        List<SpectralClass> StarsList { get;}
        LoadStatus Status { get; }
        void Execute();
    }
}
