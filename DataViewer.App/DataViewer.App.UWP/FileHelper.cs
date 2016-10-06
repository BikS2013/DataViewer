using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(DataViewer.App.UWP.FileHelper))]
namespace DataViewer.App.UWP
{
    public class FileHelper : IFileHelper
    {
        public void Delete(string fileName)
        {
        }

        public bool Exists(string fileName)
        {
            return false;
        }

        public IEnumerable<string> GetFiles()
        {
            return new string[0];
        }

        public string ReadText(string fileName)
        {
            throw new NotImplementedException();
        }

        public void WriteText(string fileName, string text)
        {
            throw new NotImplementedException();
        }
    }
}
