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
    public partial class Behavior : ContentPage
    {
        private ObservableCollection<Person> People { get; } =
    new ObservableCollection<Person>(Enumerable.Range(1, 5).Select(x => new Person() { Name = $"kuma{x}" }));
        public Behavior()
        {
            InitializeComponent();
            this.listview1.ItemsSource = this.People;
            this.listview2.ItemsSource = this.People;
        }
    }
}