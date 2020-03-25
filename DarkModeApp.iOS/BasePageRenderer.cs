using System;
using System.Diagnostics;
using DarkModeApp;
using DarkModeApp.iOS;
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
                App.ApplySystemTheme();
            }
            catch(Exception ex)
            {
                Debug.WriteLine($"\t\t\tERROR: {ex.Message}");
            }
        }

        public override void TraitCollectionDidChange(UITraitCollection previousTraitCollection)
        {
            base.TraitCollectionDidChange(previousTraitCollection);
            App.ApplySystemTheme();
        }
    }
}