using DarkModeApp.Styles;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DarkModeApp
{
    public partial class App : Application
    {
        public static string CurrentTheme { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        public static void ApplySystemTheme()
        {
            if(AppInfo.RequestedTheme == AppTheme.Dark)
            {
                // change to light theme
                // e.g. App.Current.Resources = new YourLightTheme();
                SwitchToDarkMode();
            }
            else
            {
                // change to dark theme
                // e.g. App.Current.Resources = new YourDarkTheme();
                SwitchToLightMode();
            }
        }

        public static void SwitchToDarkMode()
        {
            Current.Resources.MergedDictionaries.Clear();
            Current.Resources.MergedDictionaries.Add(new StyleGuideDarkColors());
            CurrentTheme = "Dark";
        }

        public static void SwitchToLightMode()
        {
            Current.Resources.MergedDictionaries.Clear();
            Current.Resources.MergedDictionaries.Add(new StyleGuideLightColors());
            CurrentTheme = "Light";
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}