using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AwesomeApp
{
    class NotSelectableListViewTriggerAction : TriggerAction<ListView>
    {
        protected override void Invoke(ListView sender)
        {
            sender.SelectedItem = null;
        }
    }
}
