using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.Logging;
using Trader.Infrastructure;

namespace Trader
{
    class Bootstrapper : UnityBootstrapper
    {
        private readonly EnterpriseLibraryLoggerAdapter logger = new EnterpriseLibraryLoggerAdapter();

        protected override ILoggerFacade CreateLogger()
        {
            return logger;
        }

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

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new ConfigurationModuleCatalog();
        } 

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            Container.RegisterInstance<ILoggerFacade>(logger);
        }

    }
}
