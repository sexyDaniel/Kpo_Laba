using System;
using System.Collections.Generic;
using System.Linq;
using Kpo_4311_Lazarev_lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestSpectralClass
{
    [TestClass]
    public class SpectralClassTest
    {
        private SpectralClassRepository spectralClasses;
        private IRepositoryLoader loader;

        private void Add(SpectralClass spectralClass)
        {
            spectralClasses.Add(spectralClass);
        }

        public void Initialize()
        {
            spectralClasses = new SpectralClassRepository();
            AppGlobalSettings.Initialize();
            loader = CastleFactory.Container.Resolve<IRepositoryLoader>();
            loader.FileName = AppGlobalSettings.DataFileName;
            loader.Execute();
            spectralClasses.StarsList = loader.StarsList;
        }

        [TestMethod]
        public void AddSpectralClass()
        {
            Initialize();
            var count = spectralClasses.StarsList.Count;
            spectralClasses.Add(new SpectralClass {SpectralClassName="C",MassOfTheSun=123,Part=45,Count=10909 });
            Assert.AreNotEqual(spectralClasses.StarsList.Count, count);
        }

        [TestMethod]
        public void AddExistentSpectralClass()
        {
            Initialize();
            Assert.ThrowsException<AddSpectralClassException>(()=>spectralClasses.Add(new SpectralClass { SpectralClassName = "O", MassOfTheSun = 123, Part = 45, Count = 10909 }));
        }


        [TestMethod]
        public void SearchException()
        {
            Initialize();
            Assert.ThrowsException<SearchSpectralClassExeption>(() => spectralClasses.SearchSpectralClass("Z"));
        }

        [TestMethod]
        public void DeleteSpectralClass()
        {
            Initialize();
            var count = spectralClasses.StarsList.Count;
            spectralClasses.Delete("O");
            Assert.AreNotEqual(count, spectralClasses.StarsList.Count);
        }

        [TestMethod]
        public void DeleteNonExistentSpectralClass()
        {
            Initialize();
            Assert.ThrowsException<Exception>(() => spectralClasses.Delete("Z"));
        }

        [TestMethod]
        public void EditSpectralClass()
        {
            Initialize();
            var count = spectralClasses.StarsList.Count;
            spectralClasses.Edit(new SpectralClass { SpectralClassName = "O", MassOfTheSun = 123, Part = 45, Count = 10909 });
            var sc = spectralClasses.StarsList.FirstOrDefault(sp=>sp.SpectralClassName=="O");
            Assert.AreEqual(sc.Count, 10909);
            Assert.AreEqual(sc.MassOfTheSun, 123);
            Assert.AreEqual(sc.SpectralClassName, "O");
            Assert.AreEqual(sc.Part, 45);
        }

        [TestMethod]
        public void EditNonExistentSpectralClass()
        {
            Initialize();
            var count = spectralClasses.StarsList.Count;
            Assert.ThrowsException<Exception>(()=>spectralClasses.Edit(new SpectralClass { SpectralClassName = "S", MassOfTheSun = 123, Part = 45, Count = 10909 }));
        }
    }
}
