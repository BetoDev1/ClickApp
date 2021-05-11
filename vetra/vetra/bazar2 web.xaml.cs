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
    public partial class bazar2_web : ContentPage
    {
        public bazar2_web()
        {
            InitializeComponent();
            webView.Source = "https://neadevs.com/click/bellavista/polirrubros2/bazar.html";
        }
    }
}