using System;
using Xamarin.Forms;
using Pedidos.Helpers;

namespace Pedidos.Pages.Acceso
{
    public class InicioSesion : ContentPage
    {
        Button login;
        public bool Logeado = false;

        public InicioSesion()
        {
            login = new Button()
            {                
                Text = "INGRESAR",
                TextColor = Color.FromHex("2AB4EE"),
                //FontFamily = Device.OnPlatform("OpenSans-ExtraBold", "OpenSans-ExtraBold", null),
                FontSize = 20,
                HorizontalOptions = LayoutOptions.Center,
                BackgroundColor = Color.FromHex("ffffff"),
                WidthRequest = 300,
                HeightRequest = 50
            };
            login.Clicked += Login_Clicked;
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    login
                }
            };
        }

        void Login_Clicked(object sender, EventArgs e)
        {
            Settings.session_Session_Token = "1";
            MessagingCenter.Send<InicioSesion>(this, "Autenticado");
        }
    }
}
