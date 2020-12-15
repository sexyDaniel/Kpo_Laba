using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo_4311_Lazarev_lib
{
    public class SpectralClassRepository : ISpectralClassRepository
    {
        public List<SpectralClass> StarsList { get; set; }
        public SpectralClassRepository()
        {
            StarsList = new List<SpectralClass>();
        }

        public void Add(SpectralClass spectralClass)
        {
            SpectralClass check = StarsList.FirstOrDefault(sp => sp.SpectralClassName == spectralClass.SpectralClassName);
            if (check != null)
                throw new AddSpectralClassException("Такой спектральный класс уже есть");
            StarsList.Add(spectralClass);
        }

        public void Delete(string spectralClassName)
        {
            SpectralClass deleteSpectralClass = StarsList.FirstOrDefault(sp => sp.SpectralClassName == spectralClassName);
            if (deleteSpectralClass == null)
                throw new Exception("Такого спектрального класса нет");
            StarsList.Remove(deleteSpectralClass);
        }

        public void Edit(SpectralClass spectralClass)
        {
            SpectralClass editSpectralClass = StarsList.FirstOrDefault(sp=>sp.SpectralClassName== spectralClass.SpectralClassName);
            if (editSpectralClass == null)
                throw new Exception("Такого спектрального класса нет");
            editSpectralClass.SpectralClassName = spectralClass.SpectralClassName;
            editSpectralClass.Part = spectralClass.Part;
            editSpectralClass.MassOfTheSun = spectralClass.MassOfTheSun;
            editSpectralClass.Count = spectralClass.Count;
        }

        public SpectralClass SearchSpectralClass(string spectralClassName)
        {
            SpectralClass spectralClass = StarsList.FirstOrDefault(sp => sp.SpectralClassName == spectralClassName);
            if (spectralClass == null)
                throw new SearchSpectralClassExeption("Такого спектрального класса нет");
            return spectralClass;
        }

        public void Sort()
        {
            FastSort(StarsList);
        }

        private void FastSort(List<SpectralClass> StarsList)
        {
            //пусть каким-то образом в исходном наборе выделен некий элемент x, который принято называть опорным.В простейшем случае в качестве опорного можно взять конечный элемент массива. Заведем указател  на первый элемент массива

            //просматривается часть массива, расположенная левее опорного элемента и находится первый по порядку элемент ai > x

            //Производится перестановка ai элемента с элементом, на который указывает указатель. Затем указатель сдвигается на один.

            //По окончании цикла меняем местами опорный элемент, и элемент, на который указывает указатель. Таким образом слева от опорного элемента эмементы массива, которые меньше него, а справа наоборот

            // Затем проводим теже манипуляции с частью массива, расположенным слева от опорного и справа от опрного
            throw new Exception("Метод не реализован");
        }
    }
}
