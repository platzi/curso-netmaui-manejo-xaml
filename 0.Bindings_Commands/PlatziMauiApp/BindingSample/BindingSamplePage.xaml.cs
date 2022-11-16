using System.ComponentModel;

namespace PlatziMauiApp.BindingSample;

public partial class BindingSamplePage : ContentPage
{

    public BindingSamplePage()
    {
        InitializeComponent();
        BindingContext = new TeacherViewModel();
    }
}