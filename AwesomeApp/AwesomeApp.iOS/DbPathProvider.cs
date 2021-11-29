using Foundation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof( AwesomeApp.iOS.DbPathProvider))]
namespace AwesomeApp.iOS
{
    internal class DbPathProvider : IDbPathProvider
    {
        public string GetPath()
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "..", "Library", "Database");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            };
            return Path.Combine(path, "database.db3");
        }
    }
}