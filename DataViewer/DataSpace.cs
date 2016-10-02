using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewer
{
    public class DataSpace: INotifyPropertyChanged
    {

        private bool isEditorVisible;

        public bool IsEditorVisible
        {
            get { return isEditorVisible; }
            set {
                if (value != isEditorVisible)
                {
                    isEditorVisible = value;
                    OnPropertyChanged("IsEditorVisible");
                }
            }
        }

        private string data;

        public string Data
        {
            get { return data; }
            set {
                if ( value != data)
                {
                    data = value;
                    OnPropertyChanged("Data");
                }
            }
        }

        public DataSpace()
        {
            Data = "do nothing, do nothing, do nothing, do nothing, do nothing, do nothing, do nothing, do nothing, do nothing, do nothing, do nothing, do nothing, do nothing, do nothing, do nothing, do nothing, do nothing, do nothing, do nothing, do nothing, do nothing, do nothing, do nothing, do nothing, ";
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
        }

    }
}
