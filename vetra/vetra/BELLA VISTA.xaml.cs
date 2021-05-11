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
    public partial class tercera : ContentPage
    {
        public tercera()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new hoteles2());
        }
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new gastronomia2 ());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new peluqueria2());
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new muebles2());
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new lavadero2());
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new juridico2());
        }

        private async void Button_Clicked_6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new salud2());
        }

        private async void Button_Clicked_7(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new comercios2());
        }

        private async void Button_Clicked_8(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new oficios2());
        }

        private async void Button_Clicked_9(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new consecionarias2());
        }

        private async void Button_Clicked_10(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new polirrubros2());
        }

        private async void Button_Clicked_11(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ferreterias2());
        }

        private async void Button_Clicked_12(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new remises2());
        }

        private async void Button_Clicked_13(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new agencias2());
        }

        private async void Button_Clicked_14(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new talleres2());
        }

        private async void Button_Clicked_15(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new seguros2());
        }

        private async void Button_Clicked_16(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new celulares2());
        }

        private async void Button_Clicked_17(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new tiendas2());
        }

        private async void Button_Clicked_18(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new servicios_publicos2());
        }

        private async void Button_Clicked_19(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new caza_y_pesca2());
        }

        private async void Button_Clicked_20(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new veterinarios2());
        }
    }
}