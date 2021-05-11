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
    public partial class casas_de_comidas : ContentPage
    {
        public casas_de_comidas()
        {
            InitializeComponent();
            webView.Source = "https://neadevs.com/click/goya/gastronomia/casasdecomidas.html";
        }
    }
}