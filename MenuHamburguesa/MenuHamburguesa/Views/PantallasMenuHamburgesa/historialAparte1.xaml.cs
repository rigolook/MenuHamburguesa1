using MenuHamburguesa.ViewModel;
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
	public partial class historialAparte1 : ContentPage
	{
		public historialAparte1 ()
		{
			InitializeComponent ();
            BindingContext = new VMhistorial(Navigation);

        }

    }
}