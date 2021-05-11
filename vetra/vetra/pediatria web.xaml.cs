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
    public partial class pediatria_web : ContentPage
    {
        public pediatria_web()
        {
            InitializeComponent();
            webView.Source = "https://neadevs.com/click/goya/medicos/pediatria.html";
        }
    }
}