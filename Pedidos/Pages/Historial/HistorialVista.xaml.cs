using System;
using System.Collections.Generic;
using Pedidos.ViewModels.Historial;
using Xamarin.Forms;

namespace Pedidos.Pages.Historial
{
    public partial class HistorialVista : ContentPage
    {
        public HistorialVista(HistorialVistaModelo ModeloVista)
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
