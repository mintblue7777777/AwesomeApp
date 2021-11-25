using Android.Widget;
using System;
using Xamarin.Forms.Platform.Android;

[assembly: Xamarin.Forms.ExportRenderer(typeof(AwesomeApp.CustomButton), typeof(AwesomeApp.Droid.CustomButtonRenderer))]
namespace AwesomeApp.Droid
{
    [Obsolete]
    public class CustomButtonRenderer :ViewRenderer<CustomButton,Button>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<CustomButton> e)
        {
            base.OnElementChanged(e);
           if (this.Control == null)
            {
                var button = new Button(this.Context);
                button.Click += this.OnClick;
                this.SetNativeControl(button);
            }

           if (e.NewElement != null)
            {
                this.UpdateText();
            }
        }

        private void UpdateText()
        {
            this.Control.Text = this.Element.Text;
        }

        private void OnClick(object sender, EventArgs e)
        {
            this.Element.OnClicked();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.Control.Click -= this.OnClick;
            }
            base.Dispose(disposing);
        }
    }
}