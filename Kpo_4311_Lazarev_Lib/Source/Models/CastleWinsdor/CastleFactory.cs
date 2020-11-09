using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo_4311_Lazarev_lib
{
    public enum LoadStatus
    {
        None = 0,
        Success = 1,
        FileNameIsEmpty = -1,
        FileNotExists = -2,
        GeneralError = -100,
        NoData = -3
    }
    public static class CastleFactory
    {
        public static WindsorContainer Container { get; private set; }

    static CastleFactory()
        {
            Container = new WindsorContainer();
            if (AppGlobalSettings.Mode == "File")
            {
                Container.Register(
                   Component.For<IRepositoryLoader>()
                   .ImplementedBy<SpectralClassListLoader>()
                   .LifeStyle
                   .Transient);
                Container.Register(
                   Component.For<IRepositorySaver>()
                   .ImplementedBy<SpectralClassListSaver>()
                   .LifeStyle
                   .Transient);
            }
            else
            {
                Container.Register(
                  Component.For<IRepositoryLoader>()
                  .ImplementedBy<SpectralClassSeedDataLoader>()
                  .LifeStyle
                  .Transient);
                Container.Register(
                   Component.For<IRepositorySaver>()
                   .ImplementedBy<SpectralClassSeedDataSaver>()
                   .LifeStyle
                   .Transient);
            }
       
        }
    }
}
