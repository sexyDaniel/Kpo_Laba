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
    public partial class StarForm : Form
    {
        public SpectralClass SpectralClass { get; private set; }
        public SpectralClassRepository repo { get; set; }
        public StarForm()
        {
            InitializeComponent();
            SpectralClass = null;
        }

        public void SetSpectralClass(SpectralClass spectralClass)
        {
            SpectralClass = spectralClass;
            SpectralClassTextBox.Text = SpectralClass.SpectralClassName;
            MassOfSunTextBox.Text = SpectralClass.MassOfTheSun.ToString();
            CountTextBox.Text = SpectralClass.Count.ToString();
            PartTextBox.Text = SpectralClass.Part.ToString();
        }

        private void SpectralClassTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddStar_Click(object sender, EventArgs e)
        {
            try
            {
                SpectralClass = new SpectralClass();
                SpectralClass.SpectralClassName = SpectralClassTextBox.Text;
                SpectralClass.MassOfTheSun = int.Parse(MassOfSunTextBox.Text);
                SpectralClass.Count = int.Parse(CountTextBox.Text);
                SpectralClass.Part = int.Parse(PartTextBox.Text);
                repo.Add(SpectralClass);
                MessageBox.Show("Вы добавили новый спектральный класс");
                Close();
            }
            catch (AddSpectralClassException exeption)
            {
                MessageBox.Show("Error:" + exeption.Message);
                LogUtility.ErrorLog("Exeptio" + exeption.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error:" + exception.Message);
                LogUtility.ErrorLog("Exeptio" + exception.Message);
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                SpectralClass.MassOfTheSun = int.Parse(MassOfSunTextBox.Text);
                SpectralClass.Count = int.Parse(CountTextBox.Text);
                SpectralClass.Part = int.Parse(PartTextBox.Text);
                repo.Edit(SpectralClass);
                MessageBox.Show("Вы изменили Спектральный класс " + SpectralClass.SpectralClassName);
                Close();
            }
            catch(Exception exeption)
            {
                MessageBox.Show("Error:" + exeption.Message);
                LogUtility.ErrorLog("Exeptio" + exeption.Message);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                repo.Delete(SpectralClassTextBox.Text);
                MessageBox.Show("Вы удалили Спектральный класс " + SpectralClass.SpectralClassName);
                Close();
            }
            catch (Exception exeption)
            {
                MessageBox.Show("Error:" + exeption.Message);
                LogUtility.ErrorLog("Exeptio" + exeption.Message);
            }
        }
    }
}
