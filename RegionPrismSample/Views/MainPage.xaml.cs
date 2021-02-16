using Xamarin.Forms;

namespace RegionPrismSample.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            HomeRegion.IsVisible = ((Button)sender).Text == "Home";
            ContactsRegion.IsVisible = !HomeRegion.IsVisible;
        }
    }
}
