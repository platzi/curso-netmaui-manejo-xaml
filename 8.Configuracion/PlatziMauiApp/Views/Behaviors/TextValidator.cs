using System;
using System.Text.RegularExpressions;

namespace PlatziMauiApp.Views.Behaviors
{
    public class TextValidator : Behavior<Entry>
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
            Regex reg = new Regex("[0-9]");
            bool isValid = reg.IsMatch(args.NewTextValue);
            ((Entry)sender).TextColor = isValid ? Color.FromArgb("#FF0000") : Color.FromArgb("#000000");
            ((Entry)sender).BackgroundColor = isValid ? Color.FromArgb("#FBC5D0") : Color.FromArgb("#FFFFFF");
        }
    }
}

