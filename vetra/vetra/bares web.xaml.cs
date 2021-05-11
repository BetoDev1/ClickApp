using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace vetra
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class bares : ContentPage
    {
        public bares()
        {
            InitializeComponent();
            webView.Source = "https://neadevs.com/click/goya/gastronomia/bares.html";
        }
    }
}