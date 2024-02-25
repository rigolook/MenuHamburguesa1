using MenuHamburguesa.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AirePuro.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Registrarte : ContentPage
	{
		public Registrarte ()
		{
			InitializeComponent ();
            BindingContext = new VMRegistrarse(Navigation);
        }
	}
}