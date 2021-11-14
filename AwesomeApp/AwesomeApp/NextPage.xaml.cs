using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AwesomeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NextPage : ContentPage
    {
        public NextPage(string parameter)
        {
            InitializeComponent();
            this.label.Text = parameter;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //await this.Navigation.PopModalAsync();
            await this.Navigation.PopAsync();
        }
    }
}