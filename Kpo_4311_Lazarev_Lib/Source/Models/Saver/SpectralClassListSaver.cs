using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kpo_4311_Lazarev_lib
{
    public class SpectralClassListSaver : IRepositorySaver
    {
        public string FileName { get; set; }
        public List<SpectralClass> StarsList { get; set; }
        public LoadStatus Status { get; private set; } = LoadStatus.None;

        public void Execute()
        {
            if (FileName == "")
            {
                Status = LoadStatus.FileNameIsEmpty;
                throw new Exception("File name is empty");
            }
            if (FileName == null)
            {
                Status = LoadStatus.NoData;
                throw new Exception("No Data");
            }

            using (StreamWriter writer = new StreamWriter(FileName, false))
            {
                if (StarsList.Count != 0)
                {
                    for (int i = 0; i < StarsList.Count; i++)
                    {
                        try
                        {
                            var star = StarsList[i];
                            writer.WriteLine($"{star.SpectralClassName}|{star.Part}|{star.MassOfTheSun}|{star.Count}");
                        }
                        catch (Exception ex)
                        {
                            LogUtility.ErrorLog(ex);
                            Status = LoadStatus.GeneralError;
                        }
                    }
                }
            }
            MessageBox.Show("Data was Save");
            Status = LoadStatus.Success;
        }
    }
}
