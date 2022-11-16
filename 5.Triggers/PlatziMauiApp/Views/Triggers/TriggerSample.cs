using System;
namespace PlatziMauiApp.Views.Triggers
{
	public class TriggerSample :TriggerAction<Button>
	{
        protected override void Invoke(Button sender)
        {
            sender.BackgroundColor = Color.FromArgb("#97ca3f");
            sender.FontSize = 20;
        }
    }
}

