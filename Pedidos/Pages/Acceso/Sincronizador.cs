using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Pedidos.Data;
using Pedidos.Common;

namespace Pedidos.Pages.Acceso
{
    public class Sincronizador : ContentPage
    {
        bool logeado;

        public Sincronizador(bool logeado)
        {
            this.logeado = logeado;
            ActivityIndicator indicador = new ActivityIndicator
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                IsRunning = true,
                Color = Color.White,
                WidthRequest = 50
            };
            Label Mensaje = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                TextColor = Color.Black,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                FontSize = DecimalResources.LabelFontSize,
                FontFamily = FontResources.LabelFont,
            };

            if (!logeado)
                Mensaje.Text = StringResources.SincronizadorMensaje1;
            else
                Mensaje.Text = StringResources.SincronizadorMensaje2;

            Content = new StackLayout
            {
                Padding = 15,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Spacing = 5,
                Children = { indicador, Mensaje }
            };
        }

        async Task Sincronizacion()
        {            
            MessagingCenter.Send<Sincronizador>(this, Constantes.Sincronizado);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await Sincronizacion();
        }
    }
}
