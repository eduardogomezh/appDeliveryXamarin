﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using appDeliveryXamarin.Vista.MenuPrincipal;

namespace appDeliveryXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainMenu();
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
