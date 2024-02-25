﻿using MenuHamburguesa.ViewModel;
using MenuHamburguesa.Views;
using MenuHamburguesa.Views.Pantallas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MenuHamburguesa
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Nav : ContentPage
    {
        public Nav()
        {
            InitializeComponent();
            BindingContext = new VMNav(Navigation);


        }
    }
}