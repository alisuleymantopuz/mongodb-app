using Castle.Windsor;
using FMI.Container.Installers;

namespace FMI.Container
{
    public static class Bootstrapper
    {
        public static IWindsorContainer Container { get; private set; }

        public static IWindsorContainer Initialize()
        {
            Container =new WindsorContainer();

            Container.Install(new ConfigurationInstaller())
                     .Install(new RepositoryInstaller())
                     .Install(new ValidatorInstaller())
                     .Install(new ManagerInstaller());

            return Container;
        }
    }
}
