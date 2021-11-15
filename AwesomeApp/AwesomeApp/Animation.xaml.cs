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
    public partial class Animation : ContentPage
    {
        public Animation()
        {
            InitializeComponent();
        }

        private async void ContentPage_Appearing(object sender, EventArgs e)
        {
            await this.labelAnimation.TranslateTo(100, 100);

            Func<double, double> costomEasing = t => t == 0 || t == 1 ? t : t * Math.Sin(t * Math.PI / 2);
            await this.labelAnimation.TranslateTo(100, 100, 5000, costomEasing);
            await this.labelAnimation.TranslateTo(0, 0, 500, costomEasing);

            await Task.WhenAll<bool>(
                this.labelAnimation.RotateTo(1000, 100000, Easing.SpringIn),
                this.labelAnimation.RotateXTo(800, 100000, Easing.SpringOut),
                this.labelAnimation.RotateYTo(500, 100000)
                );

        }
    }
}