using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeApp
{
    public interface IFileIO
    {
        void Save(string fileName, string text);
        string Read(string fileName);
    }
}
