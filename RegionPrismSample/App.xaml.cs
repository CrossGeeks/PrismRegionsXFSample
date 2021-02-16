using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using RegionPrismSample.ViewModels;
using RegionPrismSample.ViewModels.Regions;
using RegionPrismSample.Views;
using RegionPrismSample.Views.Regions;

namespace RegionPrismSample
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initialzer = null) : base(initialzer) { }
        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterRegionServices();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForRegionNavigation<HomeView, HomeViewModel>();
            containerRegistry.RegisterForRegionNavigation<ContactsView, ContactsViewModel>();
        }
    }
}
