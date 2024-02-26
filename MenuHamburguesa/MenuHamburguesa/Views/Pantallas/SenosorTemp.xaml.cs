﻿using MenuHamburguesa.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MenuHamburguesa.Views.Pantallas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SenosorTemp : ContentPage
	{
		public SenosorTemp()
		{
			InitializeComponent ();
            //NavigationPage.SetHasBackButton(this, false);
            BindingContext = new VMSensorTemp(Navigation);
        }
	}
}