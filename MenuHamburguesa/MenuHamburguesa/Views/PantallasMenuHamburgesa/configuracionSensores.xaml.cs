using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuHamburguesa.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MenuHamburguesa.Views.PantallasMenuHamburgesa
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class configuracionSensores : ContentPage
    {
        public configuracionSensores()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            BindingContext = new VMconfigSensores(Navigation);
        }
    }
}