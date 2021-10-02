using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    }
}
