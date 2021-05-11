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
    public partial class consecionarias2 : ContentPage
    {
        public consecionarias2()
        {
            InitializeComponent();
            webView.Source = "https://neadevs.com/click/bellavista/concecionarias2.html";
        }
    }
}