using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo_4311_Lazarev_lib
{
    public static class AppGlobalSettings
    {
        public static string DataFileName { get; private set; }
        public static string LogPath { get; private set; }
        public static string Mode { get; private set; }

        public static void Initialize()
        {
            var appConfigUtility = new AppConfigUtility();
            DataFileName = appConfigUtility.AppSetting("dataFileName");
            Debug.Assert(DataFileName == "Stars.txt", "Неверное имя файла");
            LogPath = appConfigUtility.AppSetting("logPath");
            Mode = appConfigUtility.AppSetting("Factory");
        }
    }
}


