using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewer
{
    public interface IFileHelper
    {
        bool Exists(string fileName);
        void WriteText(string fileName, string text);
        string ReadText(string fileName);
        IEnumerable<string> GetFiles();
        void Delete(string fileName);
    }
}
