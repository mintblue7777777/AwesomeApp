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
    public partial class DeviceOperation : ContentPage
    {
        public DeviceOperation()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                Device.OpenUri(new Uri("http://maps.apple.com/?=Tokyo"));
            }
            else
            {
                Device.OpenUri(new Uri("geo:0,0?q=Tokyo"));
            }
        }
    }
}