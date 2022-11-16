namespace PlatziMauiApp.Views.ExplorandoFeatures;

public partial class MapSamplePage : ContentPage
{
	public MapSamplePage()
	{
		InitializeComponent();
		Mapa();
	}

	public async void Mapa()
	{
        var location = new Location(28.3772, 81.5707);
        var options = new MapLaunchOptions { Name = "Disney World" };
        //Launching Maps
        await Map.OpenAsync(location, options);
    }

}
