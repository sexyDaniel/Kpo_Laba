using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo_4311_Lazarev_lib
{
    public interface IRepositorySaver
    {
        string FileName { get; set; }
        List<SpectralClass> StarsList { set; }
        LoadStatus Status { get; }
        void Execute();
    }
}
