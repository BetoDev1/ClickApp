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
    public partial class oficios2 : ContentPage
    {
        public oficios2()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new refrigeracion2_web());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new computacion2_web());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new celulares2_web());
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new lavarropas2_web());
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new construccion2_web());
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new electricistas2_web());
        }

        private async void Button_Clicked_6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new plomeros2_web());
        }

        private async void Button_Clicked_7(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new carpinteros2_web());
        }

        private async void Button_Clicked_8(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new cerrajeros2_web());
        }

        private async void Button_Clicked_9(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new herreros2_web());
        }
    }
}