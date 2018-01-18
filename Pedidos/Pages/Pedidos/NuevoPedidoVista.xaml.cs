using System;
using System.Collections.Generic;
using Pedidos.ViewModels.Pedidos;
using Xamarin.Forms;

namespace Pedidos.Pages.Pedidos
{
    public partial class NuevoPedidoVista : ContentPage
    {
        public NuevoPedidoVista(NuevoPedidoVistaModelo ModeloVista)
        {
            //InitializeComponent();
            //this.BindingContext = ModeloVista;
            Title = ModeloVista.Title;
            Icon = ModeloVista.Icon;

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children =
                {
                    new Image
                    {
                        Source = "iDesarrollo.jpg",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.Center
                    }
                }
            };
        }
    }
}
