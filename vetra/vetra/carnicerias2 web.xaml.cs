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
    public partial class carnicerias2_web : ContentPage
    {
        public carnicerias2_web()
        {
            InitializeComponent();
            webView.Source = "https://neadevs.com/click/bellavista/comercios2/carnicerias.html";
        }
    }
}