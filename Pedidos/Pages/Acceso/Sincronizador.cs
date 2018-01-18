using System;
using System.Threading.Tasks;
using Xamarin.Forms;

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
                FontSize = 16,
                //FontFamily = Device.OnPlatform("OpenSans", "OpenSans-Regular", null),
            };

            if (!logeado)
                Mensaje.Text = "Estamos descargando los datos por primera vez. Esto puede tardar varios minutos.";
            else
                Mensaje.Text = "Estamos actualizando los datos. Esto tardara un momento.";

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
            MessagingCenter.Send<Sincronizador>(this, "Sincronizado");
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await Sincronizacion();
        }
    }
}
