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
    public partial class bares2_web : ContentPage
    {
        public bares2_web()
        {
            InitializeComponent();
            webView.Source = "https://neadevs.com/click/bellavista/gastronomia2/bares.html";
        }
    }
}