using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using FMI.Domain.EventAggregate;
using FMI.Domain.Validators; 

namespace FMI.Container.Installers
{
    public class ValidatorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        { 
            container.Register(
                Component.For<ILoggingValidator>().ImplementedBy<LoggingValidator>().LifeStyle.Transient);

              container.Register(Component.For<EventLogValidator>().LifeStyle.Transient);
          
        }
    }
}
