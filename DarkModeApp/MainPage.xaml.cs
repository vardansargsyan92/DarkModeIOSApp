using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace DarkModeApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage
    {
        private readonly Label _label;

        public MainPage()
        {
            InitializeComponent();
            _label = new Label
                     {
                         Text = "Welcome to Xamarin forms",
                         Style = (Style) Application.Current.Resources["LabelStyle"],
                         HorizontalOptions = LayoutOptions.Center,
                         VerticalOptions = LayoutOptions.Center
                     };
        }

        private void OnSwitchToDarkMode(object sender, EventArgs e)
        {
            App.SwitchToDarkMode();
        }

        private void OnSwitchToLightMode(object sender, EventArgs e)
        {
            App.SwitchToLightMode();
        }

        private void OnConfirmCreated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContentPage
                                 {
                                     Title = "Confirm Page",
                                     Content = _label,
                                     BackgroundColor = (Color) Application.Current.Resources["BackgroundColor"]
                                 });
        }

        private void OnRejectClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContentPage
                                 {
                                     Title = "Reject Page",
                                     Content = _label,
                                     BackgroundColor = (Color) Application.Current.Resources["BackgroundColor"]
                                 });
        }
    }
}