using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo_4311_Lazarev_lib
{
    public class SpectralClassSplitFileFactory : ISpectralClassFactory
    {
        public ISpectralClassListLoader CraeteSpectralClassListLoader()
        {
            return new SpectralClassSplitFileLoader(AppGlobalSettings.DataFileName);
        }

        public ISpectralClassListSaver CraeteSpectralClassListSaver()
        {
            return new SpectralClassSplitListSaver(AppGlobalSettings.DataFileName);
        }
    }
}
