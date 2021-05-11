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
    public partial class caza_y_pesca2 : ContentPage
    {
        public caza_y_pesca2()
        {
            InitializeComponent();
            webView.Source = "https://neadevs.com/click/bellavista/cazaypesca2.html";
        }
    }
}