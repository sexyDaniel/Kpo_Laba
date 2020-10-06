using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kpo_4311_Lazarev_lib
{
    public static class LogUtility
    {
        public static void ErrorLog(string message)
        {
            File.AppendAllText("error.log", $"Время ошибки: {DateTime.Now} - {message}\n");
        }

        public static void ErrorLog(Exception ex)
        {
            File.AppendAllText("error.log", $"Время ошибки: {DateTime.Now} - {ex.Message}\n");
        }
    }
}
