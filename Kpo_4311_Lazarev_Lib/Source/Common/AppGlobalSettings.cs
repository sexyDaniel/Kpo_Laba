using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo_4311_Lazarev_lib
{
    public static class AppGlobalSettings
    {
        public static string DataFileName { get; private set; }
        public static string LogPath { get; private set; }
        public static ISpectralClassFactory SpectralClassFactory { get; private set; }

        public static void Initialize()
        {
            var appConfigUtility = new AppConfigUtility();
            LogPath = appConfigUtility.AppSetting("logPath");
            DataFileName = appConfigUtility.AppSetting("dataFileName");
            if (appConfigUtility.AppSetting("Factory") == "File")
                SpectralClassFactory = new SpectralClassSplitFileFactory();
            else
                SpectralClassFactory = new SpectralClassSeedDataFactory();
        }
    }
}


