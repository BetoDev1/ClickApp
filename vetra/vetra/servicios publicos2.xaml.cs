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
    public partial class servicios_publicos2 : ContentPage
    {
        public servicios_publicos2()
        {
            InitializeComponent();
            webView.Source = "https://neadevs.com/click/bellavista/serviciospublicos2.html";
        }
    }
}