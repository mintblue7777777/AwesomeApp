using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AwesomeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private async void btnPrev_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new MainPage());
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            Debug.WriteLine($"{e.OldTextValue} -> {e.NewTextValue}");
        }
    }
}