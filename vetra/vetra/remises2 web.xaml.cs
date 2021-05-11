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
    public partial class remises2_web : ContentPage
    {
        public remises2_web()
        {
            InitializeComponent();
            webView.Source = "https://neadevs.com/click/bellavista/remises2/remises.html";
        }
    }
}