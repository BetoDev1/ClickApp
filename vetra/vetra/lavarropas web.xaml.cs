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
    public partial class lavarropas_web : ContentPage
    {
        public lavarropas_web()
        {
            InitializeComponent();
            webView.Source = "https://neadevs.com/click/goya/oficios/lavarropas.html";
        }
    }
}