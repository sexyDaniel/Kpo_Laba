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
        public StarForm()
        {
            InitializeComponent();
            SpectralClass = null;
        }

        public void SetSpectralClass(SpectralClass spectralClass)
        {
            //инициализировать скрытое поля класса
            SpectralClass = spectralClass;
            //присвоить значение данных сотрудника элементам редактирования
            SpectralClassTextBox.Text = SpectralClass.SpectralClassName;
        }

        private void SpectralClassTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
