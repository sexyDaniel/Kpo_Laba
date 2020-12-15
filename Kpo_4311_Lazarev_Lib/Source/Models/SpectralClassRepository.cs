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
            FastSort(StarsList,0, StarsList.Count-1);
        }

        private void FastSort(List<SpectralClass> StarsList,int start,int end)
        {
            if (end == start) return;
            //пусть каким-то образом в исходном наборе выделен некий элемент x, который принято называть опорным.В простейшем случае в качестве опорного можно взять конечный элемент массива. Заведем указател  на первый элемент массива
            var pivot = StarsList[end];
            var storeIndex = start;
            //просматривается часть массива, расположенная левее опорного элемента и находится первый по порядку элемент ai > x
            for (int i = start; i <= end - 1; i++)
                if (StarsList[i].MassOfTheSun <= pivot.MassOfTheSun)
                {
                    //Производится перестановка ai элемента с элементом, на который указывает указатель. Затем указатель сдвигается на один.
                    var t = StarsList[i];
                    StarsList[i] = StarsList[storeIndex];
                    StarsList[storeIndex] = t;
                    storeIndex++;
                }
            //По окончании цикла меняем местами опорный элемент, и элемент, на который указывает указатель. Таким образом слева от опорного элемента эмементы массива, которые меньше него, а справа наоборот
            var n = StarsList[storeIndex];
            StarsList[storeIndex] = StarsList[end];
            StarsList[end] = n;
            // Затем проводим теже манипуляции с частью массива, расположенным слева от опорного и справа от опрного
            if (storeIndex > start) FastSort(StarsList, start, storeIndex - 1);
            if (storeIndex < end) FastSort(StarsList, storeIndex + 1, end);
        }
    }
}
