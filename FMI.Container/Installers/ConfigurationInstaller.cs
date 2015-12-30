using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using FMI.Domain;
using FMI.Domain.Repositories;

namespace FMI.Container.Installers
{
    public class ConfigurationInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<DomainConfiguration>().LifeStyle.Singleton);

            container.Register(Component.For<RepositoryConfiguration>().LifeStyle.Singleton);
        }
    }
}