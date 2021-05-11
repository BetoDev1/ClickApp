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
    public partial class hoteles2_web : ContentPage
    {
        public hoteles2_web()
        {
            InitializeComponent();
            webView.Source = "https://institutofermosa.com/click/prueba.html";
        }
    }
}