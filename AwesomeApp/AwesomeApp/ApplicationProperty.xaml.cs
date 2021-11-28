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
    public partial class ApplicationProperty : ContentPage
    {
        public ApplicationProperty()
        {
            InitializeComponent();
        }

        private void restore_Clicked(object sender, EventArgs e)
        {
            if (Application.Current.Properties.ContainsKey("input"))
            {
                this.entry.Text = (string)Application.Current.Properties["input"]; ;
            }
        }

        private async void store_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["input"] = this.entry.Text;
            await Application.Current.SavePropertiesAsync();
        }
    }
}