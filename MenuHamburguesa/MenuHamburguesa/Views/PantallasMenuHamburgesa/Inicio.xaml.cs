using MenuHamburguesa.Views.Pantallas;
using MenuHamburguesa.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MenuHamburguesa.ViewModel;

namespace MenuHamburguesa
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
            BindingContext = new VMInicio(Navigation);
            NavigationPage.SetHasBackButton(this, false);

        }
    }
}