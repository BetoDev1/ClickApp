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
    public partial class oficios : ContentPage
    {
        public oficios()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new refrigeracion_web());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new computacion_web());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new tec_celulares_web());
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new lavarropas_web());
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new construccion_web());
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new electricista_web());
        }

        private async void Button_Clicked_6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new plomeros_web());
        }

        private async void Button_Clicked_7(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new carpinteros_web());
        }

        private async void Button_Clicked_8(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new cerrajeros_web());
        }

        private async void Button_Clicked_9(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new herreros_web());
        }
    }
}