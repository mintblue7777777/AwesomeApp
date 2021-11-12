using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AwesomeApp
{
    class PersonDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate SilverTemplate { get; set; }
        public DataTemplate NormalTemplate { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((Person)item).Age >= 65 ? this.SilverTemplate : this.NormalTemplate;
        }
    }
}
