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
	public partial class SenGaz : ContentPage
	{
		VMSenGaz vM;
        public SenGaz ()
		{
			InitializeComponent ();
            //NavigationPage.SetHasBackButton(this, false);
            vM = new VMSenGaz(Navigation);
            BindingContext = vM;
            this.Appearing += ListaSenGaz_Appearing;
        }
        private async void ListaSenGaz_Appearing(object sender, EventArgs e)
        {
            await vM.ListarSenGaz();
        }
    }
}