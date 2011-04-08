using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Trader.Infrastructure;
using Microsoft.Practices.Prism.Logging;
 
namespace Trader.Modules.Greenblatt
{
    public class Greenblatt : IModule
    {
        private readonly IRegionManager regionManager;
        private readonly ILoggerFacade logger;

        public Greenblatt(IRegionManager regionManager, ILoggerFacade logger)
        {
            this.regionManager = regionManager;
            this.logger = logger;
        }
 
        public void Initialize()
        {
            regionManager.RegisterViewWithRegion(RegionNames.MainRegion, typeof(Views.GreenblattView));
            logger.Log("Greenblatt module initialized", Category.Info, Priority.High);
        }
     }
}
