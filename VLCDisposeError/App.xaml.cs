using System;
using VLCDisposeError.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VLCDisposeError
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var navpage = new NavigationPage(new MainPage());
            MainPage = navpage;
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
