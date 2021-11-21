using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace AwesomeApp
{
    class NotSelectableListViewBehavior:Behavior<ListView>
    {
        public static BindableProperty AttachProperty = BindableProperty.CreateAttached(
            "Attach",
            typeof(bool),
            typeof(NotSelectableListViewBehavior),
            false,
            propertyChanged:AttacheChanged
            );

        private static void AttacheChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var attach = (bool)newValue;
            if (attach)
            {
                ((ListView)bindable).Behaviors.Add(new NotSelectableListViewBehavior());
            }
            else
            {
                var b = ((ListView)bindable).Behaviors.FirstOrDefault(x => x is NotSelectableListViewBehavior);
                if (b != null)
                {
                    ((ListView)bindable).Behaviors.Remove(b);
                }
            }
        }

        protected override void OnAttachedTo(ListView bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.ItemSelected += this.Bindable_ItemSelected;
        }

        private void Bindable_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }

        protected override void OnDetachingFrom(ListView bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.ItemSelected -= this.Bindable_ItemSelected;
        }
    }
}
