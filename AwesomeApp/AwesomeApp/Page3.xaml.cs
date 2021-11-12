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
    }
}