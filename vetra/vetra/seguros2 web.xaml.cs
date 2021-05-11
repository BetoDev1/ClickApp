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
    public partial class seguros2 : ContentPage
    {
        public seguros2()
        {
            InitializeComponent();
            webView.Source = "https://neadevs.com/click/bellavista/seguros2.html";
        }
    }
}