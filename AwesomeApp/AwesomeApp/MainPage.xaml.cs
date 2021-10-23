using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AwesomeApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int count = 0;
        private void Button_Clicked(object sender, EventArgs e)
        {
            count++;
            ((Button)sender).Text = $"You clicked{count} times";
            this.labelCount.Text = $"ボタンを{count}回押した！";
        }

        private async void scrollButton_Clicked(object sender, EventArgs e)
        {
            await this.scrollView.ScrollToAsync(this.boxViewYellow, ScrollToPosition.Start, true);
            Debug.WriteLine($"Scroll potision is {this.scrollView.ScrollX},{this.scrollView.ScrollY}");

        }

        private async void btnHandle_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new Page1());
        }
    }
}
