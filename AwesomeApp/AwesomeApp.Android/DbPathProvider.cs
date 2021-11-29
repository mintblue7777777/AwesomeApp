using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

[assembly:Xamarin.Forms.Dependency(typeof(AwesomeApp.Droid.DbPathProvider))]
namespace AwesomeApp.Droid
{
    internal class DbPathProvider : IDbPathProvider

    {
        public string GetPath()
        {
            return Path.Combine(
                System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal),
                "datawbase.db3"
                );
        }
    }
}