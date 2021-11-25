using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AwesomeApp
{
    public class CustomButton :View
    {
        public static readonly BindableProperty TextProperty = BindableProperty.Create(
            "Text",
            typeof(string),
            typeof(CustomButton));

        public string Text
        {
            get { return (string)GetValue(TextProperty);}
            set { SetValue(TextProperty, value); }
        }

        public event EventHandler Clicked;
        internal void OnClicked()
        {
            this.Clicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
