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
    public partial class SearchForm : Form
    {
        public SpectralClassRepository repo = new SpectralClassRepository();
        public SearchForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SpectralClass searchSC = repo.SearchSpectralClass(SpectralClassName.Text);
                StarForm starForm = new StarForm();
                starForm.SetSpectralClass(searchSC);
                starForm.SpectralClassTextBox.ReadOnly = true;
                starForm.Delete.Enabled = true;
                starForm.AddStar.Enabled = false;
                starForm.Edit.Enabled = true;
                starForm.repo = repo;
                starForm.ShowDialog();
                Close();
            }
            catch (SearchSpectralClassExeption exeption)
            {
                MessageBox.Show("Error: " + exeption.Message);
                LogUtility.ErrorLog("Exeptio " + exeption.Message);
            }
        }
    }
}
