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
    public partial class FromPage : ContentPage
    {
        public FromPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //await this.Navigation.PushModalAsync(new NextPage("引き渡したパラメータを表示"));
            await this.Navigation.PushAsync(new NextPage("引き渡したパラメータを表示"));
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            this.label.Text = $"{((ToolbarItem)sender).Text}が押されました";
        }
    }
}