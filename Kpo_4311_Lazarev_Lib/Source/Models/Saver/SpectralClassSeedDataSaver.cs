using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kpo_4311_Lazarev_lib
{
    public class SpectralClassSeedDataSaver : ISpectralClassListSaver
    {
        public List<SpectralClass> StarsList { private get; set; }
        public LoadStatus Status { get; private set; } = LoadStatus.None;

        public SpectralClassSeedDataSaver()
        {
            StarsList = null;
        }

        public void Execute()
        {
            try
            {
                if (StarsList == null)
                    throw new Exception("No data");
                Status = LoadStatus.Success;
            }
            catch (Exception exeption)
            {
                LogUtility.ErrorLog(exeption);
                MessageBox.Show("Error: " + exeption.Message);
                Status = LoadStatus.NoData;
            }
            MessageBox.Show("Data was Save");
        }
    }
}
