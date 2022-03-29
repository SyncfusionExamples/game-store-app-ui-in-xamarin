using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GameStoreApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.GamePage();
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
