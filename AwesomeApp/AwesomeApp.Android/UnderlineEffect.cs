using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ResolutionGroupName("AwesomeApp")]
[assembly:ExportEffect(typeof(AwesomeApp.Droid.UnderlineEffect), "UnderlineEffect")]
namespace AwesomeApp.Droid
{
    public class UnderlineEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            var label = this.Control as TextView;
            if (label == null)
            {
                return;
            }

            var effetct = this.Element.Effects.First(x => x is AwesomeApp.UnderlineEffect) as AwesomeApp.UnderlineEffect;
            if (effetct.IsEnabled)
            {
                label.PaintFlags = label.PaintFlags | Android.Graphics.PaintFlags.UnderlineText;
            }
        }

        protected override void OnDetached()
        {
        }
    }
}