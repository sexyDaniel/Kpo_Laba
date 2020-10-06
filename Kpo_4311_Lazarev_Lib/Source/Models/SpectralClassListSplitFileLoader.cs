using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kpo_4311_Lazarev_lib
{
    public enum LoadStatus
    {
        None = 0,
        Success = 1,
        FileNameIsEmpty = -1,
        FileNotExists = -2,
        GeneralError = -100
    }
    public class SpectralClassListSplitFileLoader : IStarsListLoader
    {
        private readonly string fileName = "";
        public LoadStatus Status { get; private set; } = LoadStatus.None;
        public List<SpectralClass> StarsList { get; private set; } = null;

        public SpectralClassListSplitFileLoader(string fileName)
        {
            this.fileName = fileName;
        }

        public void Execute()
        {
            Status = LoadStatus.None;
            if (fileName == "")
            {
                Status = LoadStatus.FileNameIsEmpty;
                throw new Exception("File name is empty");
            }

            if (!File.Exists(fileName))
            {
                Status = LoadStatus.FileNotExists;
                throw new Exception("File not found");
            }

            using (StreamReader reader = new StreamReader(fileName))
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
