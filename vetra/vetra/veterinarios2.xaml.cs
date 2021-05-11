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
    public partial class veterinarios2 : ContentPage
    {
        public veterinarios2()
        {
            InitializeComponent();
            webView.Source = "https://neadevs.com/click/bellavista/veterinarios2.html";
        }
    }
}