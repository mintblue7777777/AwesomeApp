using Plugin.Media;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AwesomeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MediaPlugin : ContentPage
    {
        public MediaPlugin()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();
            if (CrossMedia.Current.IsPickPhotoSupported)
            {
                var file = await CrossMedia.Current.PickPhotoAsync();
                if (file == null) return;

                this.image.Source = ImageSource.FromStream(() =>
                    {
                        var ms = new MemoryStream();
                        using (var fs = file.GetStream())
                        {
                            fs.CopyTo(ms);
                        }
                        ms.Seek(0, SeekOrigin.Begin);
                        return ms;
                    }
                    );
            
            
            }
        }
    }
}