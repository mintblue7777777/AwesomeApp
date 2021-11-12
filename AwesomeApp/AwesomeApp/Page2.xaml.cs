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
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            var r = new Random();
            this.listView.ItemsSource = Enumerable.Range(1, 100).Select(x => new Person() { Name = $"{x}番目の人" ,Age= r.Next(50)+30});
        }
    }
}