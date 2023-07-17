using AYUGSI_S7.Vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AYUGSI_S7
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
            //MainPage = new NavigationPage(new ConsultaRegistro());
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
