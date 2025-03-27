namespace Astley_Aislie_POI_App_Prototype;

public partial class Page4 : ContentPage
{
	public Page4()
	{
		InitializeComponent();
	}

		private async void OnToPOI1Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new POIViews.POI1());
        }

		private async void OnToPOI2Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new POIViews.POI2());
        }

	        private async void OnToHomePageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
}