using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Kpo_4311_Lazarev_lib
{
    public class AppConfigUtility
    {
        public string AppSetting(string name)
        {
            var app = ConfigurationManager.AppSettings[name];
            return app != null ? app : "";
        }
    }
}
