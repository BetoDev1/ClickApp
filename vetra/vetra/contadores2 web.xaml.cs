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
    public partial class contadores2_web : ContentPage
    {
        public contadores2_web()
        {
            InitializeComponent();
            webView.Source = "https://neadevs.com/click/bellavista/juridico2/contadores.html";
        }
    }
}