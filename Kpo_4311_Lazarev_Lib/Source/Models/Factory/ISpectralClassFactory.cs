using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo_4311_Lazarev_lib
{
    public enum LoadStatus
    {
        None = 0,
        Success = 1,
        FileNameIsEmpty = -1,
        FileNotExists = -2,
        GeneralError = -100,
        NoData = -3
    }
    public interface ISpectralClassFactory
    {
        ISpectralClassListSaver CraeteSpectralClassListSaver();
        ISpectralClassListLoader CraeteSpectralClassListLoader();
    }
}
