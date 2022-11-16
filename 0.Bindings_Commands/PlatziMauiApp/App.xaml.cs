namespace PlatziMauiApp;

public partial class App : Application
{

    public static INavigation Navigation { get; set; }

    public App()
	{

        InitializeComponent();

        //MainPage = new AppShell();

        //MainPage = new NavigationPage(new BindingSample.BindingSamplePage());

        var navPage = new NavigationPage(new BindingSample.BindingSamplePage());
        Navigation = navPage.Navigation;
        MainPage = navPage;
    }
}

