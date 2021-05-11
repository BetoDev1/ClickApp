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
    public partial class cerrajeros2_web : ContentPage
    {
        public cerrajeros2_web()
        {
            InitializeComponent();
            webView.Source = "https://neadevs.com/click/bellavista/oficios2/cerrajeros.html";
        }
    }
}