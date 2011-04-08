using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Trader.Infrastructure;
 
namespace Trader.Modules.Greenblatt
{
    public class Greenblatt : IModule
    {
        private readonly IRegionManager regionManager;

        public Greenblatt(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }
 
        public void Initialize()
        {
            regionManager.RegisterViewWithRegion(RegionNames.MainRegion, typeof(Views.GreenblattView));
        }
     }
}
