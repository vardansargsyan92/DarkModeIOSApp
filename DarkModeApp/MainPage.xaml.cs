using System;
using System.ComponentModel;
using DarkModeApp.Styles;
using Xamarin.Forms;

namespace DarkModeApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SwitchToDarkMode(object sender, EventArgs e)
        {
            Application.Current.Resources = new DarkTheme();
            App.AppTheme = "Dark";
        }

        private void SwitchToLightMode(object sender, EventArgs e)
        {
            Application.Current.Resources = new LightTheme();
            App.AppTheme = "Light";
        }
    }
}