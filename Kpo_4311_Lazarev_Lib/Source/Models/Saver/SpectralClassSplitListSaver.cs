using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kpo_4311_Lazarev_lib
{
    public class SpectralClassSplitListSaver : ISpectralClassListSaver
    {
        private readonly string fileName;
        public List<SpectralClass> StarsList { private get; set; }
        public LoadStatus Status { get; private set; } = LoadStatus.None;

        public SpectralClassSplitListSaver(string fileName)
        {
            StarsList = null;
            this.fileName = fileName; 
        }

        public void Execute()
        {
            if (fileName == "")
            {
                Status = LoadStatus.FileNameIsEmpty;
                throw new Exception("File name is empty");
            }
            if (fileName == null)
            {
                Status = LoadStatus.NoData;
                throw new Exception("No Data");
            }

            using (StreamWriter writer = new StreamWriter(fileName,false))
            {
                if(StarsList.Count!=0)
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
