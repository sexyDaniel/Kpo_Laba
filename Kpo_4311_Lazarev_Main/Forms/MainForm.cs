using Kpo_4311_Lazarev_lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpectralClassOfStars
{
    public partial class MainForm : Form
    {
        private List<SpectralClass> spectralClasses;
        private BindingSource bsSpectralClass = new BindingSource();
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                IRepositoryLoader loader = CastleFactory.Container.Resolve<IRepositoryLoader>();
                loader.FileName = AppGlobalSettings.DataFileName;
                loader.Execute();
                spectralClasses = loader.StarsList;
                bsSpectralClass.DataSource = spectralClasses;
                dvgSpectralClass.DataSource = bsSpectralClass;
            }
            catch (NotImplementedException ex)
            {
                LogUtility.ErrorLog($"Error №1 {ex.Message}");
                MessageBox.Show($"Error №1 {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error №2 {ex.Message}");
            }
        }

        private void openStar_Click_1(object sender, EventArgs e)
        {
            try
            {
                StarForm starForm = new StarForm();
                var spectralClass = bsSpectralClass.Current as SpectralClass;
                starForm.SetSpectralClass(spectralClass);
                starForm.ShowDialog();
            }
            catch (NotImplementedException ex)
            {
                LogUtility.ErrorLog($"Error №1 {ex.Message}");
                MessageBox.Show($"Error №1 {ex.Message}");
            }
            catch (Exception ex)
            {
                LogUtility.ErrorLog(ex);
                MessageBox.Show($"Error №2 {ex.Message}");
            }
        }

        private void ExitFile_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (spectralClasses == null || spectralClasses.Count == 0)
                    throw new Exception("Table is Empty");
                IRepositorySaver listSaver = CastleFactory.Container.Resolve<IRepositorySaver>();
                listSaver.StarsList = spectralClasses;
                listSaver.FileName = AppGlobalSettings.DataFileName;
                listSaver.Execute();
            }
            catch(Exception exeption)
            {
                MessageBox.Show("Error:" + exeption.Message);
                LogUtility.ErrorLog("Exeptio" + exeption.Message);
            }
        }
    }
}
