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
    public partial class comercios2 : ContentPage
    {
        public comercios2()
        {
            InitializeComponent();
        }

        
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new supermercados2_web());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new despensas2_web());
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new carnicerias2_web());
        }

        private async  void Button_Clicked_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new panaderias2_web());
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new pollerias2_web());
        }

        private async void Button_Clicked_6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new fiambrerias2_web());
        }

        private async void Button_Clicked_7(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new verdulerias2_web());
        }

        private async void Button_Clicked_8(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new heladerias2_web());
        }

        private async void Button_Clicked_9(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new resueltos2_web());
        }
    }
}