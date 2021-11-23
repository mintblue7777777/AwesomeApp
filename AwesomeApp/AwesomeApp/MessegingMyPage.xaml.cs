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
    public partial class MessegingMyPage : ContentPage
    {
        public MessegingMyPage()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<MessegingNextPage, DateTime>(
                this,
                "completed",
                (sender, args) =>
                {
                    this.labelState.Text = $"Completed at {args}";
                });
        }

        private async void ButtonNextPage_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new MessegingNextPage());
        }
    }
}