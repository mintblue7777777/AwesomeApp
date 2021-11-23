using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Prism.Mvvm;

namespace AwesomeApp
{
    class MainPageViewModel : BindableBase
    {
        public ObservableCollection<Person> people { get; } = new ObservableCollection<Person>();

        private string message;
        public string Message
        {
            get { return this.message; }
            set { this.SetProperty(ref this.message, value); }
        }

        public Command NowCommand { get; }
        private bool canExecute;
        public bool CanExecute
        {
            get { return canExecute; }
            set
            {
                SetProperty(ref canExecute, value);
                NowCommand.ChangeCanExecute();
            }
        }

        public MainPageViewModel()
        {
            var r = new Random();
            Device.StartTimer(
                TimeSpan.FromSeconds(5),
                () =>
                {
                    if (this.people.Count >= 10) return false;
                    this.people.Add(new Person { Name = $"tanaka{r.Next()}" });
                    return true;
                });

            this.NowCommand = new Command(
                _ => this.Message = DateTime.Now.ToString(),
                _ =>this.CanExecute
                );
        }


    }
}
