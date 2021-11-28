using System;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(AwesomeApp.FileIO))]
namespace AwesomeApp
{
    public class FileIO : IFileIO
    {
        public string Read(string fileName)
        {
            var path = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                fileName);
            if (!File.Exists(path))
            {
                return String.Empty;
            }
            return File.ReadAllText(path);
        }

        public void Save(string fileName, string text)
        {
            var path = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                fileName);
            File.WriteAllText(path, text);
        }
    }
}