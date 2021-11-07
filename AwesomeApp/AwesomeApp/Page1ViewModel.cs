using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace AwesomeApp
{
    class Page1ViewModel: BindableBase
    {
        public ObservableCollection<Person> People { get; } = new ObservableCollection<Person>(
            Enumerable.Range(1, 5).Select(x => new Person { Name = $"kuma:{x}" }));

        public Command ContextActionCommand { get; }

        public Page1ViewModel()
        {
            this.ContextActionCommand = new Command(x =>
            {
                var p = (Person)x;
                Debug.WriteLine(p.Name);
            });
        }
    }
}
