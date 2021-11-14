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
    public partial class Gesture : ContentPage
    {
        public Gesture()
        {
            InitializeComponent();
        }

        public int TapCount { get; private set; }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            ((Label)sender).Text = $"DoubleTap count is {++this.TapCount}";
        }

        private void PinchGestureRecognizer_PinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
        {
            this.labelStatus.Text = $"{e.Status} : {e.Scale} : ({e.ScaleOrigin.X},{e.ScaleOrigin.Y})";
        }

        private void PanGestureRecognizer_PanUpdated(object sender, PanUpdatedEventArgs e)
        {
            this.panLabelStatus.Text = $"{e.StatusType} : ({e.TotalX},{e.TotalY})";
        }
    }
}