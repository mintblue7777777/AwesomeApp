using Foundation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms.Platform.iOS;

namespace AwesomeApp.iOS
{
    internal class UnderLineEffect : PlatformEffect
    {
        private bool IsEnabled { get; set; }   
        protected override void OnAttached()
        {

            var label = this.Control as UILabel;
            if (label == null) {
                return;
            }

            var effect = this.Element.Effects.First(x => x is AwesomeApp.UnderlineEffect) as AwesomeApp.UnderlineEffect;
            this.IsEnabled = effect.IsEnabled;

            if (this.IsEnabled)
            {
                label.AttributedText = new Foundation.NSAttributedString(
                    label.Text ?? "",
                    underlineStyle: Foundation.NSUnderlineStyle.Single);
            }
        }

        protected override void OnDetached()
        {
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            if (args.PropertyName == nameof(UILabel.Text))
            {
                var label = this.Control as UILabel;
                if (label == null)
                {
                    return;
                }

                if (this.IsEnabled)
                {
                    label.AttributedText = new Foundation.NSAttributedString(
                        label.Text ?? "",
                        underlineStyle: Foundation.NSUnderlineStyle.Single);
                }
            }
        }
    }
}