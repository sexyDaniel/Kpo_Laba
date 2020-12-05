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
    }
}
