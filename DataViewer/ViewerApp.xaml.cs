using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DataViewer
{
    public partial class ViewerApp : Application
    {
        public ViewerApp()
        {
            InitializeComponent();

            MainPage = new Startup();
        }
    }
}
