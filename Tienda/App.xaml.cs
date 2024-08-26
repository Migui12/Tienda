using System;
using Tienda.Views.Principal;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tienda.Views.Principal;

namespace Tienda
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage (new VPPrincipal());
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
