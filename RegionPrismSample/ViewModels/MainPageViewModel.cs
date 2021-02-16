using Prism.Navigation;
using Prism.Regions;
using Prism.Regions.Navigation;

namespace RegionPrismSample.ViewModels
{
    public class MainPageViewModel : IInitialize
    {
        private IRegionManager _regionManager { get; }
        public MainPageViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize(INavigationParameters parameters)
        {
            _regionManager.RequestNavigate("HomeRegion", "HomeView", RegionNavigationCallback);
            _regionManager.RequestNavigate("ContactsRegion", "ContactsView", RegionNavigationCallback);
        }

        private void RegionNavigationCallback(IRegionNavigationResult result)
        {
            // Handle any errors or anything else you need to here...
        }
    }
}
