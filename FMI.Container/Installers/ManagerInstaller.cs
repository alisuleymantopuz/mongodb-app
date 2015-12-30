using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using FMI.Domain.EventAggregate;
using FMI.Domain.Services;

namespace FMI.Container.Installers
{
    public class ManagerInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
           

            container.Register(
                  Component.For<ILoggingManager>().ImplementedBy<LoggingManager>().LifeStyle.Transient);
        }
    }
}
