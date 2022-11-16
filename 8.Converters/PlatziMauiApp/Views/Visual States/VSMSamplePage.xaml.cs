using System.Text.RegularExpressions;

namespace PlatziMauiApp.Views.VisualStates;

public partial class VSMSamplePage : ContentPage
{
	public VSMSamplePage()
	{
		InitializeComponent();
	}

    void OnTextChanged(object sender, TextChangedEventArgs args)
    {
        string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*"; 
        bool isValid = Regex.IsMatch(args.NewTextValue, expresion);
        GoToState(isValid);
    }

    void GoToState(bool isValid)
    {
        string vState = isValid ? "Correct" : "Incorrect";
        VisualStateManager.GoToState(EntryEmail, vState);
    }
}
