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
    public partial class damas_tiendas2_web : ContentPage
    {
        public damas_tiendas2_web()
        {
            InitializeComponent();
            webView.Source = "https://neadevs.com/click/bellavista/tiendas2/damas.html";
        }
    }
}