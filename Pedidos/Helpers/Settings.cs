// Helpers/Settings.cs
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace Pedidos.Helpers
{
	/// <summary>
	/// This is the Settings static class that can be used in your Core solution or in any
	/// of your client applications. All settings are laid out the same exact way with getters
	/// and setters. 
	/// </summary>
	public static class Settings
	{
		private static ISettings AppSettings
		{
			get
			{
				return CrossSettings.Current;
			}
		}

		#region Setting Constants

        private const string Session_Token = "Session_Token";
        private static readonly string Predeterminado = string.Empty;

		#endregion


        public static string session_Session_Token
        {
            get
            {
                return AppSettings.GetValueOrDefault(Session_Token, Predeterminado);
            }
            set
            {
                AppSettings.AddOrUpdateValue(Session_Token, value);
            }
        }

	}
}