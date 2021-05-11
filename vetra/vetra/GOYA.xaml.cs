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
    public partial class Segunda : ContentPage
    {
        public Segunda()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Senior());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Maxi());
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new muebles());
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new lavadero());
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new juridico());
        }

        private async void Button_Clicked_6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new salud());
        }

        private async void Button_Clicked_7(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new comercios());
        }

        private async void Button_Clicked_8(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new oficios());
        }

        private async void Button_Clicked_9(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new consecionarios());
        }

        private async void Button_Clicked_10(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new polirrubros());
        }

        private async void Button_Clicked_11(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ferreterias());
        }

        private async void Button_Clicked_12(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new remises());
        }

        private async void Button_Clicked_13(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new agencias());
        }

        private async void Button_Clicked_14(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new talleres());
        }

        private async void Button_Clicked_15(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new seguros());
        }

        private async void Button_Clicked_16(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new celulares());
        }

        private async void Button_Clicked_17(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new tiendas ());
        }

       
        private async void Button_Clicked_18(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new servicios_publicos());
        }

        private async void Button_Clicked_19(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new caza_y_pesca());
        }

        private async void Button_Clicked_20(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new veterinarios());
        }
    }
}