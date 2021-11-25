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
    public partial class CustomRenderer : ContentPage
    {
        public CustomRenderer()
        {
            InitializeComponent();
        }

        private void CustomButton_Clicked(object sender, EventArgs e)
        {
            this.label.Text = DateTime.Now.ToString();
        }
    }
}