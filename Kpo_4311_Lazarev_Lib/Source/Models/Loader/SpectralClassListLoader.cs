using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kpo_4311_Lazarev_lib
{
    public delegate void OnLoadFileDelegate(int count);
    public class SpectralClassListLoader : IRepositoryLoader
    {
        public string FileName { get; set; }
        public List<SpectralClass> StarsList { get; private set; }
        public LoadStatus Status { get; private set; } = LoadStatus.None;
        public OnLoadFileDelegate OnLoadFile { get; set; }

        public void SetDelegate(OnLoadFileDelegate del) => OnLoadFile = del;

        public void Execute()
        {
            Status = LoadStatus.None;
            if (FileName == "")
            {
                Status = LoadStatus.FileNameIsEmpty;
                throw new Exception("File name is empty");
            }

            if (!File.Exists(FileName))
            {
                Status = LoadStatus.FileNotExists;
                throw new Exception("File not found");
            }

            using (StreamReader reader = new StreamReader(FileName))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    try
                    {
                        string[] arr = line.Split('|');
                        if (StarsList == null)
                            StarsList = new List<SpectralClass>();
                        StarsList.Add(
                            new SpectralClass
                            {
                                SpectralClassName = arr[0],
                                MassOfTheSun = double.Parse(arr[1]),
                                Part = double.Parse(arr[2]),
                                Count = long.Parse(arr[3])
                            });
                        OnLoadFile?.Invoke(StarsList.Count);
                    }
                    catch (Exception ex)
                    {
                        LogUtility.ErrorLog(ex);
                        Status = LoadStatus.GeneralError;
                    }
                }
            }
            Status = LoadStatus.Success;
        }
    }
}
