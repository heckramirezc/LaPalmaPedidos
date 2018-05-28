using System;
using Xamarin.Forms;

namespace Pedidos.Common
{
    public static class FontResources
    {
        public static readonly string ButtonFont = Device.OnPlatform("OpenSans-ExtraBold", "OpenSans-ExtraBold", null);
        public static readonly string LabelFont = Device.OnPlatform("OpenSans-ExtraBold", "OpenSans-ExtraBold", null);
    }
}
