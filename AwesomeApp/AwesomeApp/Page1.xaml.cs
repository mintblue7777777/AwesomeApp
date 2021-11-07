using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AwesomeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        private ObservableCollection<Person> People { get; } = new ObservableCollection<Person>();
        private ObservableCollection<Family> People2 { get; }
        private ObservableCollection<Person> People3 { get; } = 
            new ObservableCollection<Person>(Enumerable.Range(1, 5).Select(x => new Person() { Name = $"kuma{x}" }));

        public Page1()
        {
            InitializeComponent();
            this.image.Source = ImageSource.FromFile("FacePalm.jpg");
            this.image2.Source = ImageSource.FromResource("SeatedMonkey.jpg");
            this.listView.ItemsSource = this.People;

            this.People2 = new ObservableCollection<Family>
            {
                new Family("kuma family", "k")
                {
                    new Person{Name = "Kuma1"},
                    new Person{Name = "Kuma2"},
                    new Person{Name = "Kuma3"},
                    new Person{Name = "Kuma4"},
                },
                new Family("Suzuki family", "k")
                {
                    new Person{Name = "Suzuki1"},
                    new Person{Name = "Suzuki2"},
                    new Person{Name = "Suzuki3"},
                    new Person{Name = "Suzuki4"},
                },
                new Family("Tnaka family", "t")
                {
                    new Person{Name = "Tnaka1"},
                    new Person{Name = "Tnaka2"},
                    new Person{Name = "Tnaka3"},
                    new Person{Name = "Tnaka4"},
                },
            };
            this.listview2.ItemsSource = this.People2;
            this.listview3.ItemsSource = this.People3;
            this.listview4.ItemsSource = this.People3; 
        }

        private async void btnPrev_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new MainPage());
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            Debug.WriteLine($"{e.OldTextValue} -> {e.NewTextValue}");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.People.Add(new Person { Name = $"Kuma{DateTime.Now}" });
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedItem = (Person)e.SelectedItem;
            this.lblSelectedItem.Text = selectedItem.Name;
        }

        private void listview2_Refreshing(object sender, EventArgs e)
        {

        }

        private async void listview3_Refreshing(object sender, EventArgs e)
        {

            await Task.Delay(3000);

            for(int i = 0;i < 5; i++)
            {
                this.People3.Add(new Person { Name = $"kuma{this.People3.Count + 1}" });
            }
            this.listview3.IsRefreshing = false;
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            var selectedItem = ((MenuItem)sender).BindingContext as Person;
            this.DisplayAlert("Info Menu1", $"{selectedItem.Name} selected.", "OK");
        }

        private void MenuItem_Clicked_1(object sender, EventArgs e)
        {
            var selectedItem = (Person)((MenuItem)sender).BindingContext;
            this.DisplayAlert("Info Menu2", $"{selectedItem.Name} selected.", "OK");
        }

        private void MenuItem_Clicked_2(object sender, EventArgs e)
        {
            var selectedItem = ((MenuItem)sender).BindingContext as Person;
            this.DisplayAlert("Info Menu3", $"{selectedItem.Name} selected.", "OK");
        }
    }
}