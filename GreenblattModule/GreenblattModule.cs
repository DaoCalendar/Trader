using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Trader.Infrastructure;
 
namespace GreenblattModule
{
    public class GreenblattModule : IModule
    {
        private readonly IRegionManager regionManager;

        public GreenblattModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }
 
        public void Initialize()
        {
            regionManager.RegisterViewWithRegion(RegionNames.MainRegion, typeof(Views.GreenblattView));
        }
     }
}
