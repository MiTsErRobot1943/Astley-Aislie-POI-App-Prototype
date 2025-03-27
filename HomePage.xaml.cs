namespace Astley_Aislie_POI_App_Prototype
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void OnStartClickedMain(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void OnToPage1Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

        private async void OnToPage2Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }

        private async void OnToPage3Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }
        private async void OnToPage4Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page4());
        }
    }
}
