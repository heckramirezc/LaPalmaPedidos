using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Pedidos.Models.Menu;
using Pedidos.Common;

namespace Pedidos.ViewModels.Menu
{
    public class MenuVistaModelo : BaseVistaModelo
    {
        public ObservableCollection<Menus> Menus { get; set; }
        public MenuVistaModelo()
        {
            Title = StringResources.MenuTitle;
            Menus = new ObservableCollection<Menus>();
            Menus.Add(new Menus
            {
                Id = DecimalResources.Menu1,
                Title = StringResources.Menu1,
                MenuTipo = MenuTipo.NuevoPedido,
                Icon = ImageResources.Menu1
            });
            Menus.Add(new Menus
            {
                Id = DecimalResources.Menu2,
                Title = StringResources.Menu2,
                MenuTipo = MenuTipo.Historial,
                Icon = ImageResources.Menu2
            });
            Menus.Add(new Menus
            {
                Id = DecimalResources.Menu3,
                Title = StringResources.Menu3,
                MenuTipo = MenuTipo.Configuracion,
                Icon = ImageResources.Menu3
            });
            Menus.Add(new Menus
            {
                Id = DecimalResources.Menu4,
                Title = StringResources.Menu4,
                MenuTipo = MenuTipo.Salir,
                Icon = ImageResources.Menu4
            });
        }
    }
}
