using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AwesomeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageSQlite : ContentPage
    {
        private SQLiteAsyncConnection Connection { get; }
        public PageSQlite()
        {
            InitializeComponent();
            this.Connection = new SQLiteAsyncConnection(
                DependencyService.Get<IDbPathProvider>().GetPath());
            this.Connection.CreateTableAsync<PersonTable>().Wait();
            this.LoadAsync();
        }

        private async Task LoadAsync()
        {
            this.listView.ItemsSource = await this.Connection
                .Table<PersonTable>()
                .OrderBy(x => x.Id)
                .ToListAsync();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.entryName.Text))
                return;
            await this.Connection.InsertAsync(new PersonTable { Name = this.entryName.Text });
            this.entryName.Text = "";
            await this.LoadAsync();

        }
        public class PersonTable
        {
            [PrimaryKey]
            [AutoIncrement]
            public int Id { get; set; }

            public string Name { get; set; }
        }
    }
}