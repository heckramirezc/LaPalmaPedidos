using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Pedidos.Models.Menu;

namespace Pedidos.ViewModels.Menu
{
    public class MenuVistaModelo : BaseVistaModelo
    {
        public ObservableCollection<Menus> Menus { get; set; }
        public MenuVistaModelo()
        {
            Title = "Pedidos";
            Menus = new ObservableCollection<Menus>();
            Menus.Add(new Menus
            {
                Id = 0,
                Title = "Nuevo Pedido",
                MenuTipo = MenuTipo.NuevoPedido,
                Icon = "iCaja.png"
            });
            Menus.Add(new Menus
            {
                Id = 1,
                Title = "Historial",
                MenuTipo = MenuTipo.Historial,
                Icon = "iCaja.png"
            });
            Menus.Add(new Menus
            {
                Id = 2,
                Title = "Configuración",
                MenuTipo = MenuTipo.Configuracion,
                Icon = "iCaja.png"
            });
            Menus.Add(new Menus
            {
                Id = 3,
                Title = "Salir",
                MenuTipo = MenuTipo.Salir,
                Icon = "iCaja.png"
            });
        }
    }
}
