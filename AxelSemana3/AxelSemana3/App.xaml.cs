﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AxelSemana3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Habilitar navegacion entre ventanas

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
