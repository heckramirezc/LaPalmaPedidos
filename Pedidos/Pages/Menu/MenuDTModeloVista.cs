using System;
using Pedidos.Controls;
using Pedidos.ViewModels;
using Xamarin.Forms;

namespace Pedidos.Pages.Menu
{
    public class MenuDTModeloVista : ViewCell
    {
        public MenuDTModeloVista()
        {

            IconView iconMenu = new IconView
            {
                WidthRequest = 18,
                HeightRequest = 18,
                HorizontalOptions = LayoutOptions.Center,
                Foreground = Color.FromHex("3F3F3F")
            };
            iconMenu.SetBinding(IconView.SourceProperty, BaseVistaModelo.IconPropertyName);

            Label tituloMenu = new Label
            {
                TextColor = Color.FromHex("3F3F3F"),
                FontSize = 15,
                VerticalTextAlignment = TextAlignment.Center,
                FontFamily = Device.OnPlatform("OpenSans", "OpenSans-Regular", null)
            };
            tituloMenu.SetBinding(Label.TextProperty, BaseVistaModelo.TitlePropertyName);

            Grid Menu = new Grid
            {
                Padding = new Thickness(5, 10),
                ColumnSpacing = 0,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Center,
                RowDefinitions = {
                    new RowDefinition { Height = new GridLength (0, GridUnitType.Auto) }
                },
                ColumnDefinitions = {
                    new ColumnDefinition { Width = new GridLength (40, GridUnitType.Absolute) },
                    new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) }
                }
            };

            Menu.Children.Add(iconMenu, 0, 0);
            Menu.Children.Add(tituloMenu, 1, 0);
            View = Menu;
        }
    }
}
