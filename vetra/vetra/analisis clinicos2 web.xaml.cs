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
    public partial class analisis_clinicos2_web : ContentPage
    {
        public analisis_clinicos2_web()
        {
            InitializeComponent();
            webView.Source = "https://neadevs.com/click/bellavista/medicos2/analisisclinicos.html";
        }
    }
}