using System;
namespace PlatziMauiApp.Views.Behaviors
{
	public class NumberValidator : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry entry)
        {
            entry.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(entry);
        }

        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(entry);
        }

        void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            double result;
            bool isValid = double.TryParse(args.NewTextValue, out result);
            ((Entry)sender).TextColor = isValid ? Color.FromArgb("#000000") : Color.FromArgb("#FF0000");
            ((Entry)sender).BackgroundColor = isValid ? Color.FromArgb("#FFFFFF") : Color.FromArgb("#FBC5D0");
        }
    }
}

