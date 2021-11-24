using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AwesomeApp
{
    public class UnderlineEffect : RoutingEffect
    {

        public bool IsEnabled { get; set; } = true;

        public UnderlineEffect() : base("AwesomeApp.UnderlineEffect")
        {
        }
    }
}
