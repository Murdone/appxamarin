﻿using MvvmGuia.View;
using
using Xamarin.Forms;

namespace MvvmGuia
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new Pagina1();
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
