using Windows.UI.ViewManagement;
using Xamarin.Essentials;

namespace DarkModeApp.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            LoadApplication(new DarkModeApp.App());
            var uiSettings = new UISettings();
            uiSettings.ColorValuesChanged += ColorValuesChanged;
        }

        private void ColorValuesChanged(UISettings sender, object args)
        {
            MainThread.BeginInvokeOnMainThread(DarkModeApp.App.ApplySystemTheme);
        }
    }
}