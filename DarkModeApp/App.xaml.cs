using Xamarin.Forms;

namespace DarkModeApp
{
    public partial class App : Application
    {
        public static string AppTheme { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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