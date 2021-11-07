using System.Collections.ObjectModel;

namespace AwesomeApp
{
    internal class Family:ObservableCollection<Person>
    {
        public string Name { get; set; }
        public string ShortName { get; set; }

        public Family(string v1, string v2)
        {
            this.Name = v1;
            this.ShortName = v2;
        }
    }
}