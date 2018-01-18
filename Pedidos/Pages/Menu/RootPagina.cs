using System;
using Pedidos.Helpers;
using Pedidos.Models.Menu;
using Pedidos.Pages.Configuracion;
using Pedidos.Pages.Historial;
using Pedidos.Pages.Pedidos;
using Pedidos.ViewModels.Configuracion;
using Pedidos.ViewModels.Historial;
using Pedidos.ViewModels.Pedidos;
using Xamarin.Forms;

namespace Pedidos.Pages.Menu
{
    public class RootPagina : MasterDetailPage
    {
        MenuTipo menuAnterior;
        Menu menu = new Menu();


        public RootPagina()
        {
            Title = "Pedidos";
            BackgroundColor = Color.FromHex("f7efd9");
            menu.Menus.ItemSelected += Menus_ItemSelected;
            Master = menu;
            menuAnterior = MenuTipo.Historial;
            NavegarA(MenuTipo.NuevoPedido);
            MessagingCenter.Subscribe<Menu>(this, "isPresented", (sender) =>
            {
                IsPresented = false;
            });
            
        }

        private void Menus_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var elemento = e.SelectedItem as Menus;
            if (elemento == null)
                return;
            NavegarA(elemento.MenuTipo);
            menu.Menus.SelectedItem = null;
        }

        void NavegarA(MenuTipo opcion)
        {
            if (opcion.Equals(MenuTipo.Salir))
            {
                Settings.session_Session_Token = String.Empty;

                if (string.IsNullOrEmpty((Settings.session_Session_Token)))
                {
                    if ((Device.OS == TargetPlatform.iOS) || (Device.OS == TargetPlatform.Android))
                    {
                        MessagingCenter.Send<RootPagina>(this, "noAutenticado");
                    }
                }
            }
            else
            {
                if (menuAnterior == opcion)
                {
                    IsPresented = false;
                    return;
                }
                menuAnterior = opcion;
                var mostrarPagina = PaginaPorOpcion(opcion);
                mostrarPagina.BarTextColor = Color.FromHex("ffffff");
                mostrarPagina.BarBackgroundColor = Color.FromHex("19a0e6");
                Detail = mostrarPagina;
                IsPresented = false;
            }
        }
        NavigationPage nuevoPedido, historial, configuracion;

        NavigationPage PaginaPorOpcion(MenuTipo opcion)
        {
            switch (opcion)
            {
                case MenuTipo.NuevoPedido:
                    {
                        if (Device.OS == TargetPlatform.Android)
                        {
                            MessagingCenter.Send<RootPagina>(this, "Unsubscribe");
                            nuevoPedido = null;
                        }
                        if (nuevoPedido != null)
                            return nuevoPedido;
                        var modeloVista = new NuevoPedidoVistaModelo() { Navigation = Navigation };
                        nuevoPedido = new NavigationPage(new NuevoPedidoVista(modeloVista));
                        return nuevoPedido;
                    }
                case MenuTipo.Historial:
                    {
                        if (historial != null)
                            return historial;
                        var modeloVista = new HistorialVistaModelo() { Navigation = Navigation };
                        historial = new NavigationPage(new HistorialVista(modeloVista));
                        return historial;
                    }
                case MenuTipo.Configuracion:
                    {
                        if (configuracion != null)
                            return configuracion;
                        var modeloVista = new ConfiguracionVistaModelo() { Navigation = Navigation };
                        configuracion = new NavigationPage(new ConfiguracionVista(modeloVista));
                        return configuracion;
                    }                
            }

            throw new NotImplementedException("No se reconoce el menu: " + opcion.ToString());
        }


        protected override void OnAppearing()
        {
            if (string.IsNullOrEmpty((Settings.session_Session_Token)))
            {
                base.OnAppearing();
                if ((Device.OS == TargetPlatform.iOS) || (Device.OS == TargetPlatform.Android))
                {
                    MessagingCenter.Send<RootPagina>(this, "noAutenticado");
                }
            }
        }
    }
}
