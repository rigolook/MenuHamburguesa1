﻿using MenuHamburguesa.Views;
using MenuHamburguesa.Views.Pantallas;
using MenuHamburguesa.Views.PantallasMenuHamburgesa;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MenuHamburguesa
{
    public partial class App : Application
    {
        public static MasterDetailPage MasterDet { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
            //MainPage = new NavigationPage(new RegistrarSensores());
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
