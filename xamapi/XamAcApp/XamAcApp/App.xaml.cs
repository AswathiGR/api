using DocumentFormat.OpenXml.ExtendedProperties;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamAcApp
{
    public partial class App : Xamarin.Forms.Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
