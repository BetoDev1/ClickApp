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
    public partial class niños_tienda_web : ContentPage
    {
        public niños_tienda_web()
        {
            InitializeComponent();
            webView.Source = "https://neadevs.com/click/goya/tiendas/niños.html";
        }
    }
}