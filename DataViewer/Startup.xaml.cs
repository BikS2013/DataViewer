using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DataViewer
{
    public partial class Startup : ContentPage
    {
        DataSpace workSpace; 
        public Startup()
        {
            BindingContext = workSpace = new DataSpace();
            InitializeComponent();
        }

        async void OnReadData(object sender, EventArgs e)
        {
            var pText = password.Text;
            if (await this.DisplayAlert("Try",
                $"Would you like to try {pText}?",
                "Yes", "No"))
            {

            }
        }
        void OnEdit(object sender, EventArgs e)
        {
            workSpace.IsEditorVisible = true; 
        }

        void OnSave(object sender, EventArgs e)
        {
            workSpace.IsEditorVisible = false;
        }
    }
}
