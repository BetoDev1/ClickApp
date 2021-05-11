using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace vetra
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Ciudades();
        }

        
        private void Ciudades()
        {
            btnpag3.Clicked += btnpag3_Clicked;
            btnpag4.Clicked += btnpag4_Clicked;
          
        }

        async void btnpag4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Segunda());
        }

        async void btnpag3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new tercera());
        }

        //private async void btnpag3_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new Segunda());
        //}

        //private async void btnpag4_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new tercera());
        //}

        //private async void buttonsomos_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new somos());
        //}
    }
}
