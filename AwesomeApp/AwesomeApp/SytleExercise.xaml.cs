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
    public partial class SytleExercise : ContentPage
    {
        public SytleExercise()
        {
            InitializeComponent();
            this.Resources["dynamicLabelStyle"] = this.Resources["redLabelStyle"];
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.Resources["dynamicLabelStyle"] = this.Resources["blueLabelStyle"];
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                this.Resources["dynamicLabelStyle"] = this.Resources["redLabelStyle"];
            }
            else
            {
                this.Resources["dynamicLabelStyle"] = this.Resources["yellowLabelStyle"];
            }
        }
    }
}