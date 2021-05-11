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
    public partial class agencias2 : ContentPage
    {
        public agencias2()
        {
            InitializeComponent();
            webView.Source = "https://institutofermosa.com/click/prueba.html";
        }
    }
}