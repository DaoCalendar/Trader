using System.Windows;
using Microsoft.Practices.Prism.Logging;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Unity;
using Trader.Infrastructure.Services;

namespace Trader
{
    class Bootstrapper : UnityBootstrapper
    {

        // As part of the Prism bootstrapping process, base.Logger is
        // assigned the object created here.
        protected override ILoggerFacade CreateLogger()
        {
            return new LoggingService();
        }

        // Create an instance of our base shell.
        protected override DependencyObject CreateShell()
        {
            return new Shell();
        }


        protected override void InitializeShell()
        {
            base.InitializeShell();

            App.Current.MainWindow = (Window)this.Shell;
            App.Current.MainWindow.Show();
        }

        // Create the catalog of modules to be loaded.
        protected override IModuleCatalog CreateModuleCatalog()
        {
            // The current modules are loaded from a configuration file
            return new ConfigurationModuleCatalog();
        } 

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
        }

        // Configure the IoC Container, in this case we are using Unity.
        // The container is configured and passed services that are
        // required as dependencies.
        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            // Register logger as singleton instance
            Container.RegisterInstance<ILoggerFacade>(Logger);
        }

    }
}
