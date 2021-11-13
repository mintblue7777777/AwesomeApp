using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AwesomeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
            var People = new ObservableCollection<Person>(Enumerable.Range(1, 100).Select(x => new Person() { Name = $"{x}番目の人", }));
            this.picker.ItemsSource = People;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (this.progressBar.Progress < 0.8)
            {
                await this.progressBar.ProgressTo(0.8, 5000, Easing.Linear);
            }
            else
            {
                await this.progressBar.ProgressTo(0.2, 5000, Easing.Linear);
            }
            
        }
    }
}