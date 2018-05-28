using System;
using Xamarin.Forms;
using Pedidos.Helpers;
using Pedidos.Data;
using Pedidos.Common;

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
                Text = StringResources.LoginIngresar,
                TextColor = ColorResources.LoginTextIngresar,
                FontFamily = FontResources.ButtonFont,
                FontSize = DecimalResources.ButtonFontSize,
                HorizontalOptions = LayoutOptions.Center,
                BackgroundColor = ColorResources.LoginBackgroundIngresar,
                WidthRequest = DecimalResources.ButtonWidthRequest,
                HeightRequest = DecimalResources.ButtonHeightRequest
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
            Settings.session_Session_Token = Constantes.TokenBeta;
            MessagingCenter.Send<InicioSesion>(this, Constantes.Autenticado);
        }
    }
}
