using System;
using System.Diagnostics;
using DarkModeApp;
using DarkModeApp.iOS;
using DarkModeApp.Styles;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(BasePage), typeof(BasePageRenderer))]

namespace DarkModeApp.iOS
{
    public class BasePageRenderer : PageRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            if(e.OldElement != null || Element == null)
            {
                return;
            }

            try
            {
                SetAppTheme();
            }
            catch(Exception ex)
            {
                Debug.WriteLine($"\t\t\tERROR: {ex.Message}");
            }
        }

        public override void TraitCollectionDidChange(UITraitCollection previousTraitCollection)
        {
            base.TraitCollectionDidChange(previousTraitCollection);
            Console.WriteLine($"TraitCollectionDidChange: {TraitCollection.UserInterfaceStyle} != {previousTraitCollection.UserInterfaceStyle}");

            if(TraitCollection.UserInterfaceStyle != previousTraitCollection.UserInterfaceStyle)
            {
                SetAppTheme();
            }
        }

        private void SetAppTheme()
        {
            if(TraitCollection.UserInterfaceStyle == UIUserInterfaceStyle.Dark)
            {
                if(App.AppTheme == "Dark")
                {
                    return;
                }

                Xamarin.Forms.Application.Current.Resources = new DarkTheme();

                App.AppTheme = "Dark";
            }
            else
            {
                if(App.AppTheme != "Dark")
                {
                    return;
                }
                Xamarin.Forms.Application.Current.Resources = new LightTheme();
                App.AppTheme = "Light";
            }
        }
    }
}