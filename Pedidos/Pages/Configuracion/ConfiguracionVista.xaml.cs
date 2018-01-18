using System;
using System.Collections.Generic;
using Pedidos.ViewModels.Configuracion;
using Xamarin.Forms;

namespace Pedidos.Pages.Configuracion
{
    public partial class ConfiguracionVista : ContentPage
    {
        public ConfiguracionVista(ConfiguracionVistaModelo ModeloVista)
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
