using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Models.Menu
{
    public enum MenuTipo
    {
        NuevoPedido,
        Historial,
        Configuracion,
        Salir
    }
    public class Menus
    {
        public Menus()
        {
            MenuTipo = MenuTipo.NuevoPedido;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public MenuTipo MenuTipo { get; set; }
    }
}
