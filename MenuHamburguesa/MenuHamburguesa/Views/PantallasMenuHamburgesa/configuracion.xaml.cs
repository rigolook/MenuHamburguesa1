using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuHamburguesa.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MenuHamburguesa.Views.Pantallas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class configuracion : ContentPage
	{
		public configuracion ()
		{
			InitializeComponent ();
            NavigationPage.SetHasBackButton(this, false);
			BindingContext = new VMconfigVentilador(Navigation);
        }
	}
}