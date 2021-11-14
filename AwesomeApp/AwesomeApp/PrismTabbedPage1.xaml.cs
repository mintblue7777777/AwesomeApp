using Xamarin.Forms;

namespace AwesomeApp
{
    public partial class PrismTabbedPage1 : TabbedPage
    {
        public PrismTabbedPage1()
        {
            InitializeComponent();
            this.ItemsSource = new[]
            {
                new Item{Title = "Tab1",Color = "Red"},
                new Item{Title = "Tab2",Color = "Blue"},
                new Item{Title = "Tab3",Color = "Olive"},
            };
        }
    }

    internal class Item
    {
        public string Title { get; set; }
        public string Color { get; set; }
    }
}
