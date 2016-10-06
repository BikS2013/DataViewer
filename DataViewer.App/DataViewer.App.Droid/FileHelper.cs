using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(DataViewer.App.Droid.FileHelper))]
namespace DataViewer.App.Droid
{
    public class FileHelper : IFileHelper
    {
        public void Delete(string fileName)
        {
            File.Delete(GetFilePath(fileName));
        }

        public bool Exists(string fileName)
        {
            return File.Exists(GetFilePath(fileName));
        }

        private string GetFilePath(string fileName)
        {
            return Path.Combine(GetDocsPath(), fileName);
        }

        private string GetDocsPath()
        {
            return System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
        }

        public IEnumerable<string> GetFiles()
        {
            throw new NotImplementedException();
        }

        public string ReadText(string fileName)
        {
            return File.ReadAllText(GetFilePath(fileName));
        }

        public void WriteText(string fileName, string text)
        {
            File.WriteAllText(GetFilePath(fileName), text);
        }
    }
}