using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Semana3_FernandaRevelo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            try
            {
                
                string usuario = txtUsuario.Text;
                string clave = txtClave.Text;

                
                await Navigation.PushAsync(new VistaDos(usuario, clave));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Mensaje de advertencia", ex.Message, "OK");
            }

        }


    }
}