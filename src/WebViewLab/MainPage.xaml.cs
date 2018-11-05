using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WebViewLab
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void RegularWebViewButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WebViewPage());
        }

        private async void ExtendedWebViewButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ExtendedWebViewPage());
        }
    }
}
