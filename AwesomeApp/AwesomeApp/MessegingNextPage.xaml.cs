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
    public partial class MessegingNextPage : ContentPage
    {
        public MessegingNextPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send<MessegingNextPage, DateTime>(
                this,
                "completed",
                DateTime.Now);
            await this.Navigation.PopModalAsync();
        }
    }
}