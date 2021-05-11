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
    public partial class accesorios_celular2_web : ContentPage
    {
        public accesorios_celular2_web()
        {
            InitializeComponent();
            webView.Source = "https://neadevs.com/click/bellavista/celulares2/accesorios.html";
        }
    }
}