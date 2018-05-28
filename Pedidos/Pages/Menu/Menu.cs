using System;
using System.ComponentModel;
using Xamarin.Forms;
using Pedidos.ViewModels.Menu;
using Pedidos.Common;

namespace Pedidos.Pages.Menu
{
    public class Menu : ContentPage, INotifyPropertyChanged
    {
        public ListView Menus { get; private set; }
        private MenuVistaModelo modeloVista;
        public Menu()
        {
            Icon = ImageResources.MenuIcon;
            Title = StringResources.MenuTitle;
            BindingContext = modeloVista = new MenuVistaModelo();
            BackgroundColor = Color.White;
            Menus = new ListView
            {
                ItemsSource = modeloVista.Menus,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.Transparent,
                SeparatorVisibility = SeparatorVisibility.None,
                SeparatorColor = Color.White,
                HasUnevenRows = true
            };

            Menus.ItemTemplate = new DataTemplate(typeof(MenuDTModeloVista));
            Content = new StackLayout
            {
                Padding = new Thickness(0, 50, 0, 0),
                Spacing = 0,
                VerticalOptions = LayoutOptions.StartAndExpand,
                Children =
                {
                    Menus
                }
            };
        }
    }
}
