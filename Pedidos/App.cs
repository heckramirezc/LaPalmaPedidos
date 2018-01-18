using Xamarin.Forms;
using Pedidos.Helpers;
using Pedidos.Pages.Acceso;
using Pedidos.Pages.Menu;

namespace Pedidos
{
    public partial class App : Application
    {
        public App()
        {            

            if (string.IsNullOrEmpty((Settings.session_Session_Token)))
                {MainPage = new InicioSesion();}
            else
                {IniciarSesion();}
            MessagingCenter.Subscribe<InicioSesion>(this, "Autenticado", (sender) =>
                {Sincronizacion(sender.Logeado);});

            MessagingCenter.Subscribe<RootPagina>(this, "noAutenticado", (sender) =>
                {CerrarSesion();});

            MessagingCenter.Subscribe<Sincronizador>(this, "Sincronizado", (sender) =>
                {IniciarSesion();});
        }

        public void IniciarSesion()
        {                        
            MainPage = new RootPagina();
        }

        public void Sincronizacion(bool logeado)
        {
            MainPage = new Sincronizador(logeado);
        }

        public void CerrarSesion()
        {
            MainPage = new InicioSesion();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
