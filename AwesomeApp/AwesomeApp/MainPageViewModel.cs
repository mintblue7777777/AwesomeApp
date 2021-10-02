using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System;
using Prism.Mvvm;

namespace AwesomeApp
{
    class MainPageViewModel : BindableBase
    {
        public ObservableCollection<Person> people { get; } = new ObservableCollection<Person>();
        public MainPageViewModel()
        {
            var r = new Random();
            Device.StartTimer(
                TimeSpan.FromSeconds(5),
                () =>
                {
                    this.people.Add(new Person { Name = $"tanaka{r.Next()}" });
                    return true;
                });
        }
    }
}
